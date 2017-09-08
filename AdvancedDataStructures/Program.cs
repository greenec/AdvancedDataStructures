using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllStarCell
{
    class Program
    {
        static void Main(string[] args)
        {
            String op;

            String x = Console.ReadLine();
            String y = Console.ReadLine();
            String z = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                String[] ops = Console.ReadLine().Split(' ');

                for (int j = ops.Length - 1; j > 0; j--)
                {
                    op = ops[j];

                    if (op.Length == 1)
                    {
                        i--;
                    }
                    else if (op.Equals("DIV"))
                    {

                    }
                }
            }
        }
    }
}
