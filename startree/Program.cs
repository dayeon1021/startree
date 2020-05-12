using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8-i; j++)
                    Console.Write(" ");
                for (int k = 0; k < i*2+1;k++)
                    Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
