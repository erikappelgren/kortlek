using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_kortlek
{
    class Player
    {
      
        public int Points  { get; set; }
        public string Name { get; set; }
        public List<Player> users { get; set; }

        public Player()
        {
            users = new List<Player>();
        }
        public Player(int points, string name)
        {
            Points = points;
            Name = name;
        }
    }
}
