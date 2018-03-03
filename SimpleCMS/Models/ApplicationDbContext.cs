using Microsoft.AspNet.Identity.EntityFramework;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleCMS.Models
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
  {
    public ApplicationDbContext() : base("DefaultConnection")
    {
      Database.Log = Logger.Info;
    }
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    public static ApplicationDbContext Create()
    {
      return new ApplicationDbContext();
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Content> Contents { get; set; }
    public DbSet<Media> Mediae { get; set; }
    public DbSet<Tag> Tags { get; set; }
  }
}