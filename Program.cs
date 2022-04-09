using System;
using System.Collections.Generic;

namespace StoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Classes required for this application
            // - store class
            // - player class
            // - item class

            // player goes to a store

            Store Walmart = new Store();
            Walmart.Name = "Walmart";
            Walmart.Description = "The most convenient store!";
            Walmart.Greeting();

            player player = new player();
            Console.WriteLine("What is your name?");
            //get player name from the user
            player.Name = Console.ReadLine();
            player.Greeting();

            // player sees list of items at the store
            Item Milk = new Item();
            Milk.Name = "Whole Milk";
            Milk.Description = "It's 100% milk!";
            Milk.Price = 4.99;

            Item Eggs = new Item();
            Milk.Name = "Brown Eggs";
            Milk.Description = "The purest of eggs";
            Milk.Price = 3.00;

            Item Bread = new Item();
            Milk.Name = "Wonder Bread";
            Milk.Description = "This bread is wonderful!";
            Milk.Price = 5.99;

            Item Candy = new Item();
            Milk.Name = "Hershey's";
            Milk.Description = "The number one chocolate bar";
            Milk.Price = 0.99;

            //store list
            Walmart.Items.Add(Milk);
            Walmart.Items.Add(Eggs);
            Walmart.Items.Add(Bread);
            Walmart.Items.Add(Candy);

            Console.WriteLine("Here are the items we have, please pick a number:");
            // player picks an item
            for (int i = 0; i < Walmart.Items.Count; i++)
            {
                int numberForUser = i + 1;
                Console.WriteLine($"{numberForUser}");

                Walmart.Items[i].Label(); 
            }
            // players picks another item
            int userChoice = Convert.ToInt32(Console.Read());

            //validate user options
            if (userChoice >= 1 && userChoice <= 4)
            {
                Console.WriteLine($"You choose {userChoice}");

                userChoice = userChoice - 1;

                Console.WriteLine($"Youre choice: {Walmart.Items[userChoice].Name} it costs {Walmart.Items[userChoice].Price}. Thank you for shopping!");
            }
            else
            {
                Console.WriteLine("NOT A VALID OPTION");
            }
            // player buys items
        }
    }
}
