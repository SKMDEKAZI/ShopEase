using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopEase.Models;

namespace ShopEase.Data
{
    public class ApplicationDbContext : IdentityDbContext<Staff, IdentityRole<int>, int>
    {
        private readonly PasswordHasher<Staff> _passwordHasher = new();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerRequest> CustomerRequest { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Aisle> Aisle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Rename ASP.NET Identity tables
            modelBuilder.Entity<Staff>().ToTable("Staff");
            modelBuilder.Entity<IdentityRole<int>>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("StaffRoles");
            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("StaffClaims");
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("StaffLogins");
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("StaffTokens");

            // Staff configuration
            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(s => s.PasswordHash)
                    .HasMaxLength(256)
                    .IsRequired();
            });

            var securityStampBase = "SECSTAMP-";
            var concurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678";
            var hashedPassword = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==";

            var staffMembers = new List<Staff>
{
    new Staff {
        Id = 1,
        UserName = "john.doe",
        NormalizedUserName = "JOHN.DOE",
        Email = "john.doe@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0001",
        ConcurrencyStamp = concurrencyStamp,
        Name = "John",
        Surname = "Doe",
        Role = "Floor Assistant",
        AvailabilityStatus = "Available",
        PasswordHash = hashedPassword
    },
    new Staff {
        Id = 2,
        UserName = "sikholwe.mdekazi",
        NormalizedUserName = "SIKHOLE.MDEKAZI",
        Email = "sikholwe.mdekazi@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0002",
        ConcurrencyStamp = concurrencyStamp,
        Name = "Sikholwe",
        Surname = "Mdekazi",
        Role = "Floor Assistant",
        AvailabilityStatus = "Unavailable",
        PasswordHash = hashedPassword
    },
    new Staff {
        Id = 3,
        UserName = "michael.brown",
        NormalizedUserName = "MICHAEL.BROWN",
        Email = "michael.brown@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0003",
        ConcurrencyStamp = concurrencyStamp,
        Name = "Michael",
        Surname = "Brown",
        Role = "Store Manager",
        AvailabilityStatus = "Available",
        PasswordHash = hashedPassword
    },
    // Continue pattern for remaining staff members
    new Staff {
        Id = 4,
        UserName = "emily.davis",
        NormalizedUserName = "EMILY.DAVIS",
        Email = "emily.davis@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0004",
        ConcurrencyStamp = concurrencyStamp,
        Name = "Emily",
        Surname = "Davis",
        Role = "Cashier",
        AvailabilityStatus = "Available",
        PasswordHash = hashedPassword
    },
    new Staff {
        Id = 5,
        UserName = "david.wilson",
        NormalizedUserName = "DAVID.WILSON",
        Email = "david.wilson@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0005",
        ConcurrencyStamp = concurrencyStamp,
        Name = "David",
        Surname = "Wilson",
        Role = "Stock Associate",
        AvailabilityStatus = "Busy",
        PasswordHash = hashedPassword
    },
    new Staff {
        Id = 6,
        UserName = "sophia.martinez",
        NormalizedUserName = "SOPHIA.MARTINEZ",
        Email = "sophia.martinez@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0006",
        ConcurrencyStamp = concurrencyStamp,
        Name = "Sophia",
        Surname = "Martinez",
        Role = "Floor Assistant",
        AvailabilityStatus = "Available",
        PasswordHash = hashedPassword
    },
    new Staff {
        Id = 7,
        UserName = "james.anderson",
        NormalizedUserName = "JAMES.ANDERSON",
        Email = "james.anderson@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0007",
        ConcurrencyStamp = concurrencyStamp,
        Name = "James",
        Surname = "Anderson",
        Role = "Security",
        AvailabilityStatus = "Available",
        PasswordHash = hashedPassword
    },
    new Staff {
        Id = 8,
        UserName = "olivia.taylor",
        NormalizedUserName = "OLIVIA.TAYLOR",
        Email = "olivia.taylor@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0008",
        ConcurrencyStamp = concurrencyStamp,
        Name = "Olivia",
        Surname = "Taylor",
        Role = "Floor Assistant",
        AvailabilityStatus = "Busy",
        PasswordHash = hashedPassword
    },
    new Staff {
        Id = 9,
        UserName = "robert.thomas",
        NormalizedUserName = "ROBERT.THOMAS",
        Email = "robert.thomas@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0009",
        ConcurrencyStamp = concurrencyStamp,
        Name = "Robert",
        Surname = "Thomas",
        Role = "Floor Assistant",
        AvailabilityStatus = "Available",
        PasswordHash = hashedPassword
    },
    new Staff {
        Id = 10,
        UserName = "emma.harris",
        NormalizedUserName = "EMMA.HARRIS",
        Email = "emma.harris@example.com",
        EmailConfirmed = true,
        SecurityStamp = $"{securityStampBase}0010",
        ConcurrencyStamp = concurrencyStamp,
        Name = "Emma",
        Surname = "Harris",
        Role = "Customer Service",
        AvailabilityStatus = "Available",
        PasswordHash = hashedPassword
    }
};

            modelBuilder.Entity<Staff>().HasData(staffMembers);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var staffEntries = ChangeTracker.Entries<Staff>()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entry in staffEntries)
            {
                var staff = entry.Entity;

                // Ensure passwords are always hashed
                if (!string.IsNullOrEmpty(staff.Password) && (entry.State == EntityState.Added || entry.State == EntityState.Modified))
                {
                    staff.PasswordHash = _passwordHasher.HashPassword(staff, staff.Password);
                    staff.Password = null; // Prevent plaintext password storage
                }
            }

            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

    }
}
