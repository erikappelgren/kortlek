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

                    WriteLine($"{i.Name}, your card are {cardNumber}\nWhat do you want to continue? Y/N ");
                    string anw = ReadLine().ToLower();
                    if (anw == "y")
                    {
                        i.Cards.Add(cardNumber);
                        WriteLine($"Your cards are: ");
                        foreach (var card in i.Cards)
                        {
                            WriteLine(card);
                        }
                    }
                    else if (anw == "n")
                    {
                        i.Cards.Add(cardNumber);
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
