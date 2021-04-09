using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVendasPOO.Entities;
using AppVendasPOO.Entities.Enums;


namespace AppVendasPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dados do cliente:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento (DD/MM/AAAA): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()); // Recebendo o valor da data em string e já convertendo para DateTime

            Console.WriteLine("\nDados do pedido: ");
            Console.Write("Status: ");
            OrderStatus os;
            Enum.TryParse(Console.ReadLine(), out os); // Enum recebendo o 'string' do console e convertendo para enum.

            Client client = new Client(name, email, birthDate); // Instanciando o objeto cliente com as informações.
            Order order = new Order(DateTime.Now, client, os); // Instanciando pedido com as informações.

            Console.Write("Quantidade de pedidos: ");
            int qntOrder = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qntOrder; i++)
            {
                Console.WriteLine("\nPedido #" + i + ":");
                Console.Write("Nome do produto: ");
                string pName = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(pName, price); // Intanciando o objeto Produto com suas informações.

                Console.Write("Quantidade: ");
                int qnt = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(qnt, price, product);
                order.AddItem(orderItem);

            }

            Console.WriteLine("Resumo dos Pedidos: \n" + order);

            Console.Read(); // Fim do escopo main.
        }

    }
}

