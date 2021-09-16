using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewWebShopStream.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Domain.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        //DBset
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<TextField> TextFields { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //нова роль
            builder.Entity<IdentityRole>().HasData(new IdentityRole()
            {
                Id = "80AB7036-5D4A-11E6-9903-0050569977A1",
                Name="admin",
                NormalizedName ="ADMIN",
                
            });

            //наш адмін
            builder.Entity<IdentityUser>().HasData(new IdentityUser()
            {
                Id = "80AB7036-5D4A-11E6-9903-0050569977A2",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "ggg@gmail.com",
                NormalizedEmail = "GGG@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "sa"),
                SecurityStamp = string.Empty
               
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
            {
                RoleId = "80AB7036-5D4A-11E6-9903-0050569977A1",
                UserId = "80AB7036-5D4A-11E6-9903-0050569977A2"
            });
            builder.Entity<TextField>().HasData(new TextField()
            {
                Id = new Guid("80AB7036-5D4A-11E6-9903-0050569977A3"),
                CodeWord = "PageIndex",
                Title = "Головна сторінка"
            });

            builder.Entity<TextField>().HasData(new TextField()
            {
                Id = new Guid("80AB7036-5D4A-11E6-9903-0050569977A4"),
                CodeWord = "PageServices",
                Title = "Наші послуги"
            });
            builder.Entity<TextField>().HasData(new TextField()
            {
                Id = new Guid("80AB7036-5D4A-11E6-9903-0050569977A5"),
                CodeWord = "PageContacts",
                Title = "Наші контакти"
            });
        }
        

    }
}
