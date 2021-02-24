using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_kortlek
{
    class Player
    {
        public int Points  { get; set; }
        public string Name { get; set; }
        public List<int> Cards { get; set; }

        public Player()
        {

        }

        public Player(int points, string name)
        {
            Points = points;
            Name = name;
            Cards = new List<int>();
        }
    }
}
