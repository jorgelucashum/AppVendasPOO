using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string birthday = Console.ReadLine();

            Console.WriteLine("\nDados do pedido: ");
            Console.Write("Status: ");
            string status = Console.ReadLine();
            Console.Write("Quantidade de pedidos: ");
            int qntOrder = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qntOrder; i++)
            {
                Console.WriteLine("\nPedido #" + i + ":");
                Console.Write("Nome do produto: ");
                string pName = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int qnt = int.Parse(Console.ReadLine());


            }
        }

    }
}

