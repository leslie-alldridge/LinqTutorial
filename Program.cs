using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data source
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Query (query syntax)
            var querySyntax = from obj in list
                              where obj > 2
                              select obj;

            WriteLine("Query Syntax ----");

            // Execution
            foreach (var item in querySyntax)
            {
                WriteLine(item);
            }

            WriteLine("Method Syntax ----");

            // Query (method syntax)
            var methodSyntax = list.Where(obj => obj > 2);

            // Execution
            foreach (var item in methodSyntax)
            {
                WriteLine(item);
            }

            WriteLine("Mixed Syntax ----");

            var mixedSyntax = (from obj in list
                               select obj).Max();
            WriteLine($"Max value is: {mixedSyntax}");
        }
    }
}
