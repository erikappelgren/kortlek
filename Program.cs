using System;
using static System.Console;
using System.Collections.Generic;

namespace OOP_kortlek
{
    class Program
    {
        private static List<Player> users { get; set; }

        static void Main(string[] args)
        {
            users = new List<Player>();
            Welcome();
            Console.WriteLine("main");
            Deal();
        }

        static void Welcome()
        {
            int playerCount = 0;
            WriteLine("Welcome To card 21");
            WriteLine("How manny players are there? ");
            try
            {
              playerCount  = int.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("you fucked up");
            }
           
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"What is player {i} name?");
                string playername = Console.ReadLine();
                Player obj = new Player(100, playername);
                users.Add(obj); 
            }
        }

        static void Deal()
        {
            Console.WriteLine("deal");
            List<int> listOfCards = new List<int>();
            for(int i = 1; i < 14; i++)
            {
                listOfCards.Add(i);
                listOfCards.Add(i);
                listOfCards.Add(i);
                listOfCards.Add(i);
            }
            
            //foreach(int card in listOfCards)
            //{
            //    Console.WriteLine(card);
            //}
            Random rnd = new Random();
            int index = rnd.Next(1, listOfCards.Count);
            index -= 1;
            int cardNumber = listOfCards[index];
            listOfCards.Remove(index);
            foreach(Player i in users)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
    
}
