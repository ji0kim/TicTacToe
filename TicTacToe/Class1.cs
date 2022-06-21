using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; } = 0;
        public bool Turn { get; set; }


        public Player() { }
        public Player( string name) {
            Name = name;
        }
        public Player(string name, bool turn)
        {
            Name = name;
            Turn = turn;
        }
    }
}
