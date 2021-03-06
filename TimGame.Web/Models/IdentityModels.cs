﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TimGame.Web.Models;

namespace TimGame.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class TimGameUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<TimGameUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class TimGameDbContext : IdentityDbContext<TimGameUser>
    {
        public TimGameDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TimGameDbContext Create()
        {
            return new TimGameDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Character>().HasOptional(x => x.Stats).WithRequired(x => x.Character).Map(x=>x.MapKey("CharacterId"));

           
        }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Text> Texts { get; set; }
    }
}