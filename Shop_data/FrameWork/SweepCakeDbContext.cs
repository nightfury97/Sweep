namespace Shop_data.FrameWork
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SweepCakeDbContext : DbContext
    {
        public SweepCakeDbContext()
            : base("name=SweepCakeDbContext")
        {
        }

        public virtual DbSet<Cake_Image> Cake_Image { get; set; }
        public virtual DbSet<Cake_Type> Cake_Type { get; set; }
        public virtual DbSet<Cake> Cakes { get; set; }
        public virtual DbSet<Cart> Carts { get; set; } 
        public virtual DbSet<Cart_Item> Cart_Item { get; set; }
        public virtual DbSet<Chef> Chefs { get; set; }
        public virtual DbSet<COMMENT> COMMENTs { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer_Payment_Methods> Customer_Payment_Methods { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<LoginSystem> LoginSystems { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Payment_Methods> Payment_Methods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cake_Image>()
                .Property(e => e.Cake_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cake_Type>()
                .Property(e => e.Cake_Type_Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cake>()
                .Property(e => e.Cake_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cake>()
                .Property(e => e.Cake_Type_Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cake>()
                .HasMany(e => e.Cart_Item)
                .WithRequired(e => e.Cake)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.Customer_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.Customer_Payment_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.Driver_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .HasMany(e => e.Cart_Item)
                .WithRequired(e => e.Cart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cart_Item>()
                .Property(e => e.Cake_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Chef>()
                .Property(e => e.Chef_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Chef>()
                .Property(e => e.Chef_Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMMENT>()
                .Property(e => e.Customer_ID)
                .IsUnicode(false);

            modelBuilder.Entity<COMMENT>()
                .Property(e => e.Cake_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Payment_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Payment_Methods>()
                .Property(e => e.Customer_Payment_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Payment_Methods>()
                .Property(e => e.Customer_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Payment_Methods>()
                .Property(e => e.Payment_Menthod_Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Payment_Methods>()
                .Property(e => e.Card_Number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Payment_Methods>()
                .Property(e => e.Date_from)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Payment_Methods>()
                .Property(e => e.Date_to)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.Driver_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.Driver_Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoginSystem>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<LoginSystem>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<LoginSystem>()
                .HasOptional(e => e.Chef)
                .WithRequired(e => e.LoginSystem);

            modelBuilder.Entity<LoginSystem>()
                .HasOptional(e => e.Customer)
                .WithRequired(e => e.LoginSystem);

            modelBuilder.Entity<LoginSystem>()
                .HasOptional(e => e.Driver)
                .WithRequired(e => e.LoginSystem);

            modelBuilder.Entity<LoginSystem>()
                .HasOptional(e => e.Manager)
                .WithRequired(e => e.LoginSystem);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Manager_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Manager_Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payment_Methods>()
                .Property(e => e.Payment_Method_Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payment_Methods>()
                .HasMany(e => e.Customer_Payment_Methods)
                .WithOptional(e => e.Payment_Methods)
                .HasForeignKey(e => e.Payment_Menthod_Code);
        }
    }
}
