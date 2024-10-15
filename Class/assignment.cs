using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;

namespace oops
{
        class Program
    {
        static List<CreditCard> creditCards = new List<CreditCard>();
        static void AddCard()
        {
            var cc = new CreditCard();

            Console.Write("Enter Card holder name: ");
            cc.CardHolderName = Console.ReadLine();

            Console.Write("Enter Card number: ");
            cc.CardNumber = Console.ReadLine();

            Console.Write("Enter expiry: ");
            cc.Expiry = int.Parse(Console.ReadLine());

            Console.Write("Enter CVV: ");
            cc.Cvv = int.Parse(Console.ReadLine());
            
            creditCards.Add(cc);
        }

        static void UpdateCard()
        {
            Console.Write("Enter Card holder name to update: ");
            string name = Console.ReadLine();

            foreach (var cc in creditCards)
            {
                if (cc.CardHolderName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter new card holder name: ");
                    cc.CardHolderName = Console.ReadLine();

                    Console.Write("Enter Card number: ");
                    cc.CardNumber = Console.ReadLine();

                    Console.Write("Enter expiry: ");
                    cc.Expiry = int.Parse(Console.ReadLine());

                    Console.Write("Enter CVV: ");
                    cc.Cvv = int.Parse(Console.ReadLine());

                    Console.WriteLine("Card update successful");
                }
                
            }
        }

        static void DeleteCard()
        {
            Console.Write("Enter Card holder name to delete: ");
            string name = Console.ReadLine();

            for (int i = 0; i < creditCards.Count; i++)
            {
                if (creditCards[i].CardHolderName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    creditCards.RemoveAt(i);
                }
            }
            Console.WriteLine("Card deleted successfully");
        }

        static void SearchCard()
        {
            Console.Write("Enter Card holder name: ");
            string name = Console.ReadLine();

            foreach (var cc in creditCards)
            {
                if (cc.CardHolderName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Cardholder: {cc.CardHolderName}, Card Number: {cc.CardNumber}, Expiry: {cc.Expiry}, CVV: {cc.Cvv}");
                    return;
                }
            }
            Console.WriteLine("card details fetched successfully");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add Card: ");
                Console.WriteLine("2.Update Card: ");
                Console.WriteLine("3.Delete Card: ");
                Console.WriteLine("4.Search details by name: ");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddCard();
                        break;
                    case "2":
                        UpdateCard();
                        break;
                    case "3":
                        DeleteCard();
                        break;
                    case "4":
                        SearchCard();
                        break;
                }
            }       
            Console.ReadLine();
        }
        
    }
}
