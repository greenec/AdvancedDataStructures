using System;
using System.Collections.Generic;
using System.Linq;

namespace AllStarCell {
    class Program {
        static void Main(string[] args)
        {
            String op, temp;
            List<String> stack = new List<String>();
            Dictionary<String, String> vars = new Dictionary<String, String>();

            vars["X"] = Console.ReadLine();
            vars["Y"] = Console.ReadLine();
            vars["Z"] = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                String[] ops = Console.ReadLine().Split(' ');

                for (int j = ops.Length - 1; j >= 0; j--)
                {
                    op = ops[j];

                    if (op.Length == 1)
                    {
                        stack.Add(vars[op]);
                    }
                    else if (op.Equals("DIV"))
                    {
                        temp = stack[stack.Count - 1];

                        stack[stack.Count - 1] = temp.Substring(0, 4) + temp.Substring(0, 4) + " and " + temp.Substring(4, 4) + temp.Substring(4, 4);
                    }
                    else if (op.Contains("ADD"))
                    {
                        temp = stack[stack.Count - 1].Substring(0, opNumber(op));

                        stack[stack.Count - 1] = temp + temp + stack[stack.Count - 1].Substring(temp.Length, 8 - (temp.Length * 2));
                    }
                    else if (op.Contains("SUB"))
                    {
                        temp = stack[stack.Count - 1].Substring(opNumber(op));

                        stack[stack.Count - 1] = temp + alphabetize(stack[stack.Count - 1].Substring(8 - opNumber(op)));
                    }
                    else if (op.Equals("UNI"))
                    {
                        stack[stack.Count - 1] = alphabetize(stack[stack.Count - 1].Substring(4, 4)) + alphabetize(stack[stack.Count - 2].Substring(0, 4));
                    }
                    else if (op.Equals("INT"))
                    {
                        stack[stack.Count - 1] = alphabetize(stack[stack.Count - 1].Substring(0, 2) + stack[stack.Count - 1].Substring(6, 2));
                        stack[stack.Count - 1] += alphabetize(stack[stack.Count - 2].Substring(0, 2) + stack[stack.Count - 2].Substring(6, 2));
                    }
                    else if (op.Equals("ALI"))
                    {
                        stack[stack.Count - 1] = reverse(alphabetize(stack[stack.Count - 1]));
                    }
                }

                Console.WriteLine(stack[stack.Count - 1]);
            }
        }

        static String alphabetize(String str)
        {
            char[] arr = str.ToArray();
            Array.Sort(arr);
            return new String(arr);
        }

        static int opNumber(String str)
        {
            return Convert.ToInt32(str.Substring(str.Length - 1));
        }

        static String reverse(String str)
        {
            char[] arr = str.ToArray();
            Array.Reverse(arr);
            return new String(arr);
        }
    }
}
