using System;
using n_queens_solution.solvers;

namespace n_queens_solution
{
    class Program
    {
        static void Main(string[] args) 
        {
            ISolver solver;
            var input  = "";
            do {
                Console.WriteLine("Choose an algorithm (0 for exit)");
                Console.WriteLine("");
                Console.WriteLine("1. Breadth-first search ");
                Console.WriteLine("2. Depth-first search");
                Console.WriteLine("3. Uniform cost search");
                
                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                    {
                        break;
                    }
                    case "1":
                    {
                        solver = new BFSSolver();
                        break;
                    }
                    case "2":
                    {
                        solver = new DFSSolver();
                        break;
                    }
                    case "3":
                    {
                        solver = new UCSSolver();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
                }
            } while (input != "0");
        }
    }
}
