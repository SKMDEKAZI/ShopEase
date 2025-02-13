using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopEase.Data;
using ShopEase.Models;

namespace ShopEase
{
    public class CustomerRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerRequests
        public async Task<IActionResult> Index()
        {
            var customerRequests = _context.CustomerRequest.Include(c => c.Aisle).ToList();
            var aisles = _context.Aisle.ToList();

            ViewBag.Aisles = aisles; // Pass aisles to the view

            var applicationDbContext = _context.CustomerRequest.Include(c => c.Aisle).Include(c => c.Customer).Include(c => c.Staff);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: CustomerRequests/HomeRequests
        public async Task<IActionResult> HomeRequests()
        {
            var customerRequests = await _context.CustomerRequest
                .Include(c => c.Aisle)
                .Include(c => c.Customer)
                .Include(c => c.Staff)
                .ToListAsync();

            return View(customerRequests);
        }
        // GET: CustomerRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerName");
            if (id == null)
            {
                return NotFound();
            }

            var customerRequest = await _context.CustomerRequest
                .Include(c => c.Aisle)
                .Include(c => c.Customer)
                .Include(c => c.Staff)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerRequest == null)
            {
                return NotFound();
            }

            return View(customerRequest);
        }

        // GET: CustomerRequests/Create
        public IActionResult Create()
        {
            ViewData["AisleID"] = new SelectList(_context.Set<Aisle>(), "AisleID", "AisleName");
            ViewData["Aisle"] = _context.Aisle.ToList(); 
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerName");
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "AvailabilityStatus");
            return View();
        }



        // POST: CustomerRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AisleID,CustomerID,RequestStatus,RequestDate")] CustomerRequest customerRequest)
        {
            // Auto-set values before validation
            customerRequest.RequestStatus ??= "Pending";
            customerRequest.RequestDate = DateTime.Now;

            // Custom validation
            if (customerRequest.AisleID < 1)
            {
                ModelState.AddModelError("AisleID", "Please select a valid aisle");
            }

            if (ModelState.IsValid)
            {
                // Ensure StaffID remains null
                customerRequest.StaffID = null;

                _context.Add(customerRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = customerRequest.Id });
            }

            // Repopulate dropdowns if validation fails
            ViewData["AisleID"] = new SelectList(_context.Set<Aisle>(), "AisleID", "AisleName", customerRequest.AisleID);
            ViewData["CustomerID"] = new SelectList(
                _context.Customer,
                "CustomerID",
                "CustomerName + ' ' + CustomerSurname",
                customerRequest.CustomerID
            );

            return View(customerRequest);
        }


        // GET: CustomerRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerRequest = await _context.CustomerRequest.FindAsync(id);
            if (customerRequest == null)
            {
                return NotFound();
            }
            ViewData["AisleID"] = new SelectList(_context.Set<Aisle>(), "AisleID", "AisleName", customerRequest.AisleID);
            ViewData["CustomerID"] = new SelectList(
         _context.Customer,
         "CustomerID",
         "CustomerName + ' ' + CustomerSurname",
         customerRequest.CustomerID);

            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "AvailabilityStatus", customerRequest.StaffID);
            return View(customerRequest);
        }

        // POST: CustomerRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AisleID,CustomerID,RequestStatus,StaffID,RequestDate")] CustomerRequest customerRequest)
        {
            if (id != customerRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerRequestExists(customerRequest.Id))
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
            ViewData["AisleID"] = new SelectList(_context.Set<Aisle>(), "AisleID", "AisleName", customerRequest.AisleID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerEmail", customerRequest.CustomerID);
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "AvailabilityStatus", customerRequest.StaffID);
            return View(customerRequest);
        }

        // GET: CustomerRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerRequest = await _context.CustomerRequest
                .Include(c => c.Aisle)
                .Include(c => c.Customer)
                .Include(c => c.Staff)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerRequest == null)
            {
                return NotFound();
            }

            return View(customerRequest);
        }

        // POST: CustomerRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerRequest = await _context.CustomerRequest.FindAsync(id);
            if (customerRequest != null)
            {
                _context.CustomerRequest.Remove(customerRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerRequestExists(int id)
        {
            return _context.CustomerRequest.Any(e => e.Id == id);
        }
    }
}
