using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
                List<string> formulae = new List<string>();
                string ready = "n";
                while (ready != "y") 
                { 
                    Console.WriteLine("Formaula? (num sym num...");
                    formulae.Add(Console.ReadLine());
                    Console.WriteLine("Any more formulae?");
                    ready = Console.ReadLine();
                }
                foreach (string formula in formulae)
                {
                    List<string> eq = new List<string>(formula.Split());
                    foreach (string j in new string[4] { "/", "*", "+", "-" }) while (eq.Contains(j)) for (int i = 0; i < eq.Count; i++) if (eq[i] == j)
                    {
                        if (j == "/") eq[i - 1] = Convert.ToString(Convert.ToInt32(eq[i - 1]) / Convert.ToInt32(eq[i + 1]));
                        if (j == "*") eq[i - 1] = Convert.ToString(Convert.ToInt32(eq[i - 1]) * Convert.ToInt32(eq[i + 1]));
                        if (j == "+") eq[i - 1] = Convert.ToString(Convert.ToInt32(eq[i - 1]) + Convert.ToInt32(eq[i + 1]));
                        if (j == "-") eq[i - 1] = Convert.ToString(Convert.ToInt32(eq[i - 1]) - Convert.ToInt32(eq[i + 1]));
                        eq.RemoveAt(i);
                        eq.RemoveAt(i);
                    }
                    Console.WriteLine(eq[0]);
                }
            }
        }
    }
}
