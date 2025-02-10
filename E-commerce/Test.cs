using System.Collections.Generic;
using E_commerce.DatabaseContext;
using E_commerce.Entities;

namespace E_commerce
{
    public class Test
    {
        public static void TestDB()
        {
            using (var context = new OnlineStoreDBContext())
            {
                
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                
                List<Customer> customers = new List<Customer>()
                {
                    new Customer { Name = "Danilo Pelaso", Email = "pelasod@gmail.com" },
                    new Customer { Name = "The Weeknd", Email = "weeknd@gmail.com" },
                    new Customer { Name = "Taylor Swift", Email = "taylor@gmail.com" },
                    new Customer { Name = "Travis Scott", Email = "travis@gmail.com" }
                };

                context.Customers.AddRange(customers);
                context.SaveChanges(); 

                
                List<Item> items = new List<Item>()
                {
                    new Item { Name = "Dell Laptop", Price = "2342344", Quantity = 12 },
                    new Item { Name = "HP Laptop", Price = "234234", Quantity = 12 },
                    new Item { Name = "LENOVO Laptop", Price = "324", Quantity = 12 }
                };

                context.Items.AddRange(items);
                context.SaveChanges(); 

               
                var order1 = new Order { Amount = "2342344", CustomerId = customers[0].Id }; 
                var order2 = new Order { Amount = "234234", CustomerId = customers[1].Id }; /

                context.Orders.AddRange(order1, order2);
                context.SaveChanges(); 

                
                var orderItem1 = new OrderItem { OrderId = order1.OrderNumber, ItemId = items[0].Id }; 
                var orderItem2 = new OrderItem { OrderId = order1.OrderNumber, ItemId = items[1].Id }; 
                var orderItem3 = new OrderItem { OrderId = order2.OrderNumber, ItemId = items[2].Id }; 

                context.OrderItems.AddRange(orderItem1, orderItem2, orderItem3);
                context.SaveChanges(); 

                
                System.Console.WriteLine("Test data has been added successfully!");
            }
        }
    }
}
