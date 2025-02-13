using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopEase.Data;
using ShopEase.Models;
using ShopEase.Utilities;
using System.Text.Json;

namespace ShopEase
{
    public class StaffsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<Staff> _signInManager;
        private readonly UserManager<Staff> _userManager;
        private readonly ILogger<StaffsController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ShopEase.Utilities.WebSocketManager _webSocketManager; // Explicit namespace

        public StaffsController(
            ApplicationDbContext context,
            SignInManager<Staff> signInManager,
            UserManager<Staff> userManager,
            ILogger<StaffsController> logger,
            IHttpContextAccessor httpContextAccessor,
            ShopEase.Utilities.WebSocketManager webSocketManager) // Explicit namespace
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _webSocketManager = webSocketManager;
        }

        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Retrieving all staff members.");
            return View(await _context.Staff.ToListAsync());
        }

        public IActionResult Login()
        {
            return View();
        }

        // POST: Staffs/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Error = "Username and password are required.";
                return View();
            }

            var staff = await _userManager.FindByNameAsync(userName);
            if (staff == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid credentials. Please try again.");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(staff, password, isPersistent: false, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Invalid credentials. Please try again.");
                return View();

            }

            if (await _userManager.IsInRoleAsync(staff, "Admin"))
            {
                return RedirectToAction("AdminDashboard", "Admin");
            }
            return RedirectToAction("Dashboard");

        }
        public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            var requests = await _context.CustomerRequest
                .Include(c => c.Aisle)
                .Include(c => c.Customer)
                .Include(c => c.Staff)
                .Where(r => (r.StaffID == null || r.StaffID == user.StaffID) &&
                            (r.RequestStatus == "Pending" || r.RequestStatus == "InProgress"))
                .ToListAsync();

            var viewModel = new StaffDashboardViewModel
            {
                Staff = user,
                Requests = requests
            };

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult UpdateRequestStatus(int id, string status)
        {
            var request = _context.CustomerRequest.FirstOrDefault(r => r.Id == id);
            if (request == null)
            {
                return Json(new { success = false, message = "Request not found" });
            }

            request.RequestStatus = status;
            _context.SaveChanges();

            return Json(new { success = true });
        }


        private async Task SendWebSocketUpdate(object data)
        {
            try
            {
                var json = JsonSerializer.Serialize(data);
                var bytes = Encoding.UTF8.GetBytes(json);
                await _webSocketManager.BroadcastAsync(bytes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending WebSocket update");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompleteRequest(int id)
        {
            var request = await _context.CustomerRequest.FindAsync(id);
            if (request == null) return NotFound();

            request.RequestStatus = "Completed";
            _context.Update(request);
            await _context.SaveChangesAsync();

            // Send WebSocket update
            await SendWebSocketUpdate(new
            {
                type = "request_completed",
                id = request.Id,
                status = request.RequestStatus
            });

            return Json(new { success = true });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AcceptRequest(int id)
        {
            var request = await _context.CustomerRequest
                .Include(r => r.Staff)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (request == null) return NotFound();

            // Update request status
            request.RequestStatus = "InProgress";

            // Update staff availability
            var staff = await _userManager.GetUserAsync(User);
            staff.AvailabilityStatus = "Busy";

            await _userManager.UpdateAsync(staff);
            _context.Update(request);
            await _context.SaveChangesAsync();

            // Send WebSocket update
            await SendWebSocketUpdate(new
            {
                type = "request_updated",
                id = request.Id,
                status = request.RequestStatus,
                staffId = staff.Id
            });

            return Json(new { success = true });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult GeneratePassword()
        {
            var passwordHasher = new PasswordHasher<object>();
            string hashedPassword = passwordHasher.HashPassword(null, "ShopEase123!");
            _logger.LogInformation("Generated password hash: {Hash}", hashedPassword);
            return RedirectToAction("Index");

        }



        // GET: Staffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff
                .FirstOrDefaultAsync(m => m.StaffID == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // GET: Staffs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Staffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffID,Name,Surname,Role,AvailabilityStatus")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                staff.PasswordHash = _userManager.PasswordHasher.HashPassword(staff, "DefaultPassword123!");
                _context.Add(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(staff);
        }

        // GET: Staffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }
            return View(staff);
        }

        // POST: Staffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaffID,Name,Surname,Role,AvailabilityStatus")] Staff staff)
        {
            if (id != staff.StaffID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffExists(staff.StaffID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(staff);
        }

        // GET: Staffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff
                .FirstOrDefaultAsync(m => m.StaffID == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // POST: Staffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staff = await _context.Staff.FindAsync(id);
            if (staff != null)
            {
                _context.Staff.Remove(staff);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffExists(int id)
        {
            return _context.Staff.Any(e => e.StaffID == id);
        }
    }
}
