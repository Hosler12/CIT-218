using Microsoft.EntityFrameworkCore;

namespace OnMyOwn.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Phone> Phone { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Phone>().HasData(
                new Phone { PhoneId = 1, PhoneName = "Mini-Phone", PhoneType = "Mobile" },
                new Phone { PhoneId = 2, PhoneName = "Super-Phone", PhoneType = "Mobile" },
                new Phone { PhoneId = 3, PhoneName = "Mega-Phone", PhoneType = "Lanline" },
                new Phone { PhoneId = 4, PhoneName = "Multi-Phone", PhoneType = "Landline" },
                new Phone { PhoneId = 5, PhoneName = "Classic-Phone", PhoneType = "Mobile" }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Amanda Apple",
                    CustomerPhone = "231-499-5412",
                    Address = "01 Fictional Road",
                    City = "Traverse City",
                    State = "Michigan",
                    PhoneId = 3
                },
                new Customer
                {
                    CustomerId = 2,
                    CustomerName = "Barry Burro",
                    CustomerPhone = "231-454-4545",
                    Address = "23 Almost Real Drive",
                    City = "Traverse City",
                    State = "Mich",
                    PhoneId = 3
                },
                new Customer
                {
                    CustomerId = 3,
                    CustomerName = "Cindy Cavendish",
                    CustomerPhone = "231-489-8474",
                    Address = "45 Kind of Fake Street",
                    City = "Traverse City",
                    State = "Panic",
                    PhoneId = 5
                },
                new Customer
                {
                    CustomerId = 4,
                    CustomerName = "Danny Dacca",
                    CustomerPhone = "231-458-5454",
                    Address = "67 Entirely False Boulevard",
                    City = "Traverse City",
                    State = "MI",
                    PhoneId = 4
                },
                new Customer
                {
                    CustomerId = 5,
                    CustomerName = "Emily ",
                    CustomerPhone = "231-848-6842",
                    Address = "89 Something Witty Avenue",
                    City = "Traverse City",
                    State = "MI",
                    PhoneId = 4
                }
            );
        }
    }
}