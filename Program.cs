using System;
using static System.Console;
using System.Collections.Generic;

namespace OOP_kortlek
{
    class Program
    {
        //public List<Player> users = new List<Player>();
        static void Main(string[] args)
        {
            //Welcome();
            Deal();
        }
        static void Welcome()
        {
            //List<Player> users = new List<Player>();
            int playerCount = 0;
            WriteLine("Welcome To card 21");
            WriteLine("How manny players are there? ");
            try
            {
              playerCount  = int.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("you fucked up");
                Welcome(); 
            }
           
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"What is player {i} name?");
                string playername = Console.ReadLine();
                Player obj = new Player(100, playername);
                //Player.users.Add(obj); FIXA
            }
        }
        static void Deal()
        {
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

            
        }
    }
    
}
