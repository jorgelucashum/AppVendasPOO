using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVendasPOO.Entities.Enums;

namespace AppVendasPOO.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } // 'DateTime' para pegar a hora de agora no pc local.
        public Client Client { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>(); // 'Intanciando uma lista para armezanar os Itens do pedido'

        public Order() // Cosntrutor vazio.
        { 
        }

        public Order(DateTime moment, Client client, OrderStatus orderStatus) // Construtor.
        {
            Moment = moment;
            Client = client;
            Status = orderStatus;
        }

        public void AddItem(OrderItem item) // Método para adicionar um tipo 'OrderItem'.
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total() // Método para retornar a soma total de todos os produtos.
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            // StringBuilder para transformar vários dados em um String organizado.
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine("Data do pedido: " + Moment.ToString("dd/MM/yyyy - HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Client);
            sb.AppendLine("\nItens do pedido: ");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço Total R$: " + Total().ToString("F2"));

            return sb.ToString();
        }

    }
}
