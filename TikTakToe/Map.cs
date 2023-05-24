using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public class Map
    {
        public int size
        {get; set;}

        public int[,] field
        { get; set; }

        public int drawCount = 0;

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
            for (int i = 0; i < size; i++)
            {
                if (field[x,i] != playerNumber)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckRow(int y, int playerNumber)
        {
            for(int i = 0; i<size; i++)
            {
                if (field[i, y] != playerNumber)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckDiagonal1(int playerNumber)
        {
            for (int i = 0; i < size; i++)
            {
                if(field[i,i] != playerNumber)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckDiagonal2(int playerNumber)
        {
            for (int i = 0; i < size; i++)
            {
                if (field[i, size-1-i] != playerNumber)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckDraw()
        {
            drawCount++;
            if(drawCount == (size * size))
            {
                return true;
            }
            return false;
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

