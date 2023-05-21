using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    partial class Program
    {
        static void Main(string[] args)
        {
            const int playerNumber = 2;
            Map m = new Map(3);
            m.printMap();
            Player[] players = new Player[playerNumber];
            players = createPlayers(playerNumber);

            for (int i = 0; true; i++)
            {
                int activePlayerIndex = i % playerNumber;
                Player activeplayer = players[activePlayerIndex];
                Console.WriteLine("Player " + (activePlayerIndex+1) + "'s turn.");

            }
        }

        static Player[] createPlayers(int num)
        {
            Player[] players = new Player[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter name for Player " + (i+1) + " : ");
                string name = Console.ReadLine();
                players[i] = new Player(i+1, name);
            }
            return players;
        }


    }
}
