using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{

    public struct CoordinateDirections
    {
        public CoordinateDirections(int XDirection, int YDirection)
        {
            xDirection = XDirection;    
            yDirection = YDirection;
        }
        public int xDirection { get; }         // -1,0,1
        public int yDirection { get; }         // -1,0,1
    }

    public class Map
    {
        public int size
        {get; set;}

        public int[,] field
        { get; set; }

        public Map(int fieldSize)
        {
            size = fieldSize;
            field = new int[fieldSize, fieldSize];

            for(int i = 0; i<fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    field[i, j] = -1;
                }
            }
        }

        public bool checkWinConditions()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (field[x,y] != -1)
                    {

                        List<(int,int)> indexPairs = nearbyMatches()
                    }
                }
            }
        }

        List<(int, int)> nearbyMatches(CoordinateDirections cd, int playerNum, int x, int y)
        {
            List<(int, int)> indexPairs = new List<(int, int)>();
            for (int i = -1; i <= 1; i++)
            {
                if (x + i >= 0 && x + i < size)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (y + j >= 0 && y + j < size && !(i == 0 && j == 0))
                        {
                            if(field[x+i, y+j] == playerNum)
                            {
                                indexPairs.Add((x + i, y + j));
                            }
                        }
                    }
                }
                    
            }

            foreach (var pair in indexPairs)
            {
                if(!(((pair.Item1 - cd.xDirection )== x) || ((pair.Item2 - cd.yDirection) == y)))
                {
                    indexPairs.Remove(pair);
                }
            }
        }

        public void printMap()
        {
            for (int i = 0; i < size; i++)
            {

                for (int k = 0; k < size - 1; k++)
                {
                    Console.Write("     |");
                }
                Console.Write("     ");
                Console.Write("\n");

                for (int j = 0; j < size; j++)
                {
                    char c = ' ';
                    if (field[i, j] == 0)
                    {
                        c = 'X';
                    }
                    else if (field[i, j] == 1)
                    {
                        c = 'O';
                    }


                    if (j == size - 1)
                    {
                        Console.Write("  " + c + "  \n");
                        break;
                    }
                    Console.Write("  " + c + "  |");
                }

                if (i < size-1) { 
                    for (int k = 0; k < size - 1; k++)
                    {
                        Console.Write("_____|");
                    }
                    Console.Write("_____\n");
                }
                else
                {
                    for (int k = 0; k < size - 1; k++)
                    {
                        Console.Write("     |");
                    }
                    Console.Write("     \n");
                }
            }
        }
    }
}

