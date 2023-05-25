/* Map.cs
 * Author: Linus-Cl
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public class Map
    {
        public int Size
        {get; set;}

        public int[,] Field
        { get; set; }

        public int drawCount = 0;

        public Map(int fieldSize)
        {
            Size = fieldSize;
            Field = new int[fieldSize, fieldSize];

            for(int i = 0; i<fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    Field[i, j] = -1;
                }
            }
        }

        public bool CheckWinCondition(int x, int y, int playerNumber)
        {
            if(CheckCol(x,playerNumber) || CheckRow(y,playerNumber) || CheckDiagonal1(playerNumber) || CheckDiagonal2(playerNumber))
            {
                return true;
            }
            return false;
        }

        bool CheckCol(int x, int playerNumber)
        {
            for (int i = 0; i < Size; i++)
            {
                if (Field[x,i] != playerNumber)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckRow(int y, int playerNumber)
        {
            for(int i = 0; i<Size; i++)
            {
                if (Field[i, y] != playerNumber)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckDiagonal1(int playerNumber)
        {
            for (int i = 0; i < Size; i++)
            {
                if(Field[i,i] != playerNumber)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckDiagonal2(int playerNumber)
        {
            for (int i = 0; i < Size; i++)
            {
                if (Field[i, Size-1-i] != playerNumber)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckDraw()
        {
            drawCount++;
            if(drawCount == (Size * Size))
            {
                return true;
            }
            return false;
        }

        public void printMap()
        {
            for (int i = 0; i < Size; i++)
            {

                for (int k = 0; k < Size - 1; k++)
                {
                    Console.Write("     |");
                }
                Console.Write("     ");
                Console.Write("\n");

                for (int j = 0; j < Size; j++)
                {
                    char c = ' ';
                    if (Field[i, j] == 0)
                    {
                        c = 'X';
                    }
                    else if (Field[i, j] == 1)
                    {
                        c = 'O';
                    }


                    if (j == Size - 1)
                    {
                        Console.Write("  " + c + "  \n");
                        break;
                    }
                    Console.Write("  " + c + "  |");
                }

                if (i < Size-1) { 
                    for (int k = 0; k < Size - 1; k++)
                    {
                        Console.Write("_____|");
                    }
                    Console.Write("_____\n");
                }
                else
                {
                    for (int k = 0; k < Size - 1; k++)
                    {
                        Console.Write("     |");
                    }
                    Console.Write("     \n");
                }
            }
        }
    }
}

