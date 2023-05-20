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
            //Player a = new Player(1, "Linus");
            Map m = new Map(5);
            m.printMap();
        }


    }
}
