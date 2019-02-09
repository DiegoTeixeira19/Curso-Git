using System;
using System.Globalization;
using Program_122.Entities;
using Program_122.Entities.Enums;

namespace Program_122 
{
    class Program 
    {

        static void Main(string[] args) 
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine("Enter cliente data:");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("E-mail: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status - 'PENDING_PAYMENT', 'PROCESSING', 'SHIPPED', 'DELIVERED': ");
            OrderStatus os;
            Enum.TryParse(Console.ReadLine(), true, out os);

            Client cl = new Client(name, email, birthDate);
            Order order = new Order(dt, os, cl);

            Console.WriteLine("How many items to this order ?");
            int qttOrder = int.Parse(Console.ReadLine());            

            for (int i = 1; i <= qttOrder; i++) 
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price:");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                Console.WriteLine("Quantity:");
                int productQuantity = int.Parse(Console.ReadLine());
               
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.addItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            Console.ReadKey();
        }
    }
}
