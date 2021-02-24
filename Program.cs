using System;
using static System.Console;
using System.Collections.Generic;
namespace OOP_kortlek
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            Console.WriteLine("Hello World!");
            
        }
        static void Welcome()
        {
            List<Player> users = new List<Player>();
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
                users.Add(obj);
            }
        }
    }
    
}
