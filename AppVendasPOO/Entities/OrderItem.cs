﻿
namespace AppVendasPOO.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product.Name}, R$: {Price.ToString("F2")}, Quantidade: {Quantity}, Total: {SubTotal().ToString("F2")}";
        }
    }
}
