using ElementsComposition2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElementsComposition2.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem i in Itens)
            {
                sum += i.SubTotal();
            }
            return sum;
        }
    }
}
