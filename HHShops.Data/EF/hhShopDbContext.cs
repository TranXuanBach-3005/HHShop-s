using HHShops.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HHShops.Data.EF
{
    public class hhShopDbContext : DbContext
    {
        public hhShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ApplicationRoleGroup>().ToTable("ApplicationRoleGroups").HasKey(n => new { n.GroupId, n.RoleId });
            //modelBuilder.Entity<ApplicationUserGroup>().ToTable("ApplicationUserGroups").HasKey(n => new { n.GroupId, n.UserId });
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetails").HasKey(n => new { n.OrderID, n.ProductID });
            modelBuilder.Entity<PostTag>().ToTable("PostTags").HasKey(n => new { n.TagID, n.PostID });
            modelBuilder.Entity<ProductTag>().ToTable("ProductTags").HasKey(n => new { n.TagID, n.ProductID });
            //Indentity
            //modelBuilder.Entity<IdentityUserRole>().ToTable("ApplicationUserRoles").HasKey(i => new { i.UserId, i.RoleId });
            //modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId).ToTable("ApplicationUserLogins");
            //modelBuilder.Entity<IdentityRole>().ToTable("ApplicationRoles");
            //modelBuilder.Entity<IdentityUserClaim>().HasKey(i => i.UserId).ToTable("ApplicationUserClaims");
            //throw new UnintentionalCodeFirstException();
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public DbSet<Error> Errors { set; get; }
        public DbSet<ContactDetail> ContactDetails { set; get; }
        public DbSet<Feedback> Feedbacks { set; get; }
        //public DbSet<ApplicationGroup> ApplicationGroups { set; get; }
        //public DbSet<ApplicationRole> ApplicationRoles { set; get; }
        //public DbSet<ApplicationRoleGroup> ApplicationRoleGroups { set; get; }
        //public DbSet<ApplicationUserGroup> ApplicationUserGroups { set; get; }
    }
}
