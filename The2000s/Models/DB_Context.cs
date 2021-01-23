using CodeFirstStoreFunctions;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace The2000s.Models
{
    public partial class DB_Context : DbContext
    {
        public DB_Context()
            : base("name=DB_Context")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ImportProduct> ImportProducts { get; set; }
        public virtual DbSet<ImportProductDetail> ImportProductDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public DbSet<OrderDetailsByID> OrderDetailsByIDs { get; set; }
        public DbSet<ImportDetailsByID> ImportDetailsByIDs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImportProduct>()
                .HasMany(e => e.ImportProductDetails)
                .WithRequired(e => e.ImportProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ImportProductDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductTypes)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("ProductTypeDetail").MapLeftKey("ProductID").MapRightKey("TypeID"));

            modelBuilder.Conventions.Add(new FunctionsConvention<DB_Context>("dbo"));
        }

        [DbFunction("DB_Context", "ShowOrderByID")]
        public IQueryable<OrderDetailsByID> ShowOrderByID(int id)
        {
            var idParameter = new ObjectParameter("id", id);

            return ((IObjectContextAdapter)this).ObjectContext
                .CreateQuery<OrderDetailsByID>(
                    string.Format("[{0}].{1}", GetType().Name,
                        "[ShowOrderByID](@id)"), idParameter);
        }
        [DbFunction("DB_Context", "ShowImportByID")]
        public IQueryable<ImportDetailsByID> ShowImportByID(int id)
        {
            var idParameter = new ObjectParameter("id", id);

            return ((IObjectContextAdapter)this).ObjectContext
                .CreateQuery<ImportDetailsByID>(
                    string.Format("[{0}].{1}", GetType().Name,
                        "[ShowImportByID](@id)"), idParameter);
        }
    }
}
