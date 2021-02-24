using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace OOP_kortlek
{
    class Program
    {
        private static List<Player> users { get; set; }
        private static List<int> listOfCards { get; set; }

        static void Main(string[] args)
        {
            listOfCards = new List<int>();
            for (int i = 1; i < 14; i++)
            {
                listOfCards.Add(i);
                listOfCards.Add(i);
                listOfCards.Add(i);
                listOfCards.Add(i);
            }
            users = new List<Player>();
            Welcome();
            FirstDeal();
        }

        static void Welcome()
        {
            int playerCount = 0;
            WriteLine("Welcome To card 21");
            WriteLine("How manny players are there? ");
            try
            {
                playerCount = int.Parse(Console.ReadLine());
            }
            catch
            {
                WriteLine("you fucked up");
            }

            for (int i = 0; i < playerCount; i++)
            {
                WriteLine($"What is player {i} name?");
                string playername = Console.ReadLine();
                Player obj = new Player(100, playername);
                users.Add(obj);
            }
        }

        static void FirstDeal()
        {
            foreach (Player i in users)
            {
                Random rnd = new Random();
                int index = rnd.Next(1, listOfCards.Count);
                index -= 1;
                int cardNumber = listOfCards[index];
                listOfCards.Remove(index);

                WriteLine($"{i.Name}, your card are {cardNumber}\nWhat do you want to bet? Your scor is {i.Points}");
                int anw = int.Parse(ReadLine());
                i.Points -= anw;
                if (cardNumber == 1)
                {
                    Console.WriteLine("You got an ace, do you want a 1 or 14?");
                    int num = int.Parse(Console.ReadLine());
                    if (num == 14)
                    {
                        cardNumber = 14;
                    }
                }
                i.Cards.Add(cardNumber);
            }
            Deal();
        }

        static void Deal()
        {
            foreach (Player i in users)
            {
                while (i.Cards.Sum() < 21)
                {
                    Random rnd = new Random();
                    int index = rnd.Next(1, listOfCards.Count);
                    index -= 1;
                    int cardNumber = listOfCards[index];
                    listOfCards.Remove(index);
                    if(cardNumber == 1)
                    {
                        Console.WriteLine("You got an ace, do you want a 1 or 14?");
                        int num = int.Parse(Console.ReadLine());
                        if(num == 14)
                        {
                            cardNumber = 14;
                        }
                    }
                    i.Cards.Add(cardNumber);

                    

                    WriteLine($"{i.Name}, your card are {cardNumber}\nYour total is {i.Cards.Sum()} ");
                    if (i.Cards.Sum() == 21)
                    {
                        Console.WriteLine("White jack!!!!");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("");
                        break;
                    }

                    else if (i.Cards.Sum() > 21)
                    {
                        Console.WriteLine("You're trash at this game");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("");
                        break;
                    }
                    Console.WriteLine("What do you want to continue? Y/N");
                    

                    string anw = ReadLine().ToLower();
                    if (anw == "y")
                    {
                        
                        WriteLine($"Your cards are: ");
                        foreach (var card in i.Cards)
                        {
                            WriteLine(card);
                        }
                        Console.WriteLine($"Your total is {i.Cards.Sum()}");
                    }
                    else if (anw == "n")
                    {
                        
                        foreach (var card in i.Cards)
                        {
                            WriteLine($"Your cards are:\n{card} ");
                        }
                        Deal();
                    }
                    else
                    {
                        WriteLine("You can only select Y or N ");
                    }

                    
                }
            }

        }
    }

}
