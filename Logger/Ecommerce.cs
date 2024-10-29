using EcommercsSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EcommercsSite.Cart;

namespace EcommercsSite
{
    public class Cartitems
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Cartitems(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public decimal TotalPrice()
        {
            return Quantity * Price;
        }
    }

    public class Cart
    {
        private List<Cartitems> items = new List<Cartitems>();

        public void Add(Cartitems item)
        {
            var existingItems = items.FirstOrDefault(i => i.Name == item.Name);
            if (existingItems != null)
            {
                existingItems.Quantity += item.Quantity;
            }
            else 
            {
                items.Add(item);
            }
        }

        public void Update(string itemName, int newQuantity)
        {
            var item = items.FirstOrDefault(i => i.Name == itemName);
            if (item != null)
            {
                item.Quantity = newQuantity;
                if (item.Quantity == 0)
                {
                    Remove(item);
                }
            }
        }
        public void Remove(Cartitems item)
        {
            items.Remove(item);
        }

        public List<Cartitems> GetItems()
        {
            return items;
        }

        public class Billing
        {
            public decimal CalculateTotal(Cart cart)
            {
                return cart .GetItems().Sum(i => i.TotalPrice());
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Cart cart = new Cart();
            Billing billing = new Billing();

            cart.Add(new Cartitems("Laptop", 1, 99999.99m));
            cart.Add(new Cartitems("Mobile", 1, 999.99m));
            cart.Update("Laptop", 2);
            cart.Update("Mobile", 3);

            decimal totalCost = billing.CalculateTotal(cart);

            Console.WriteLine($"Total Price: {totalCost}");
            Console.WriteLine($"Total Items : {cart}");
        }
    }
}

