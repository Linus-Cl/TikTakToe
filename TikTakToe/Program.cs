﻿using System;
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
            const int mapSize = 3;
            Map m = new Map(mapSize);
            // m.printMap();
            Player[] players = new Player[playerNumber];
            players = createPlayers(playerNumber);

            for (int i = 0; true; i++)
            {
                int activePlayerIndex = i % playerNumber;
                Player activeplayer = players[activePlayerIndex];
                Console.WriteLine("Player " + (activePlayerIndex + 1) + "'s turn.");
                bool validCoords = false;

                int[] coords = { 0, 0 };

                //coords = getCoords();

                while (!validCoords)
                {
                    coords = getCoords();

                    if (coords[0] < mapSize && coords[1] < mapSize)
                    {
                        validCoords = true;
                        break;
                    }
                    Console.WriteLine("Invalid Coordinates! Try again.");
                }

                m.field[coords[1], coords[0]]= activePlayerIndex;
                Console.WriteLine();
                m.printMap();
                Console.WriteLine();
            }
        }

        static int[] getCoords()
        {
            int[] coords = new int[2];
            Console.WriteLine("Choose wich field to mark:");
            Console.WriteLine("x-coordinate (starting with 0): ");
            coords[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("y-coordinate (starting with 0): ");
            coords[1] = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            return coords;
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
