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


/*
     |     |     
  X  |  O  |     
_____|     |     

*/