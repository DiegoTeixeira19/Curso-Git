using Program_122.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Program_122.Entities 
{
    class Order 
    {

        public DateTime moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client) 
        {
            this.moment = moment;
            Status = status;
            this.client = client;
        }

        public void addItem(OrderItem item) 
        {

            Item.Add(item);

        }

        public void removeItem(OrderItem item) 
        {

            Item.Remove(item);

        }

        public double total() 
        {

            double sum = 0;

            foreach (OrderItem item in Item) 
            {

                sum += item.subTotal(); 

            }

            return sum;
        }

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Item) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }



    }
}
