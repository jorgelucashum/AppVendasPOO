using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVendasPOO.Entities
{
    class Order
    {
        public DateTimeKind Moment { get; set; }
        public List<OrderItem> Status { get; set; } = new List<OrderItem>(); 


        public void AddItem(OrderItem item)
        {
            Status.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Status.Remove(item);
        }

        public double Total(double sum)
        {
            foreach(OrderItem obj in Status)
            {
                sum += obj.Price * obj.Price;
            }
            return sum;
        }
    }
}
