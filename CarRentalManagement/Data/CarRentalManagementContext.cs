using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Data;
using CarRentalManagement.Configurations.Entities;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext(DbContextOptions<CarRentalManagementContext> options) : IdentityDbContext<CarRentalManagementUser>(options)
    {
        public DbSet<CarRentalManagement.Components.Layout.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Layout.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Layout.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Layout.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Layout.Domain.Vehicle> Vehicle { get; set; } = default!;

        public DbSet<CarRentalManagement.Components.Layout.Domain.Model> Model { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
