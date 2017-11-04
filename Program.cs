using System;
using System.IO;
using n_queens_solution.solvers;

namespace n_queens_solution
{
    class Program
    {
        static void Main(string[] args) 
        {
            ISolver solver;

            int dimension = 0;
            string input  = "";
            do {
                Console.WriteLine("Choose an algorithm and Dimension (Enter for Exit)");
                Console.WriteLine("");
                Console.WriteLine("BFS");
                Console.WriteLine("DFS");
                Console.WriteLine("UCS");
                Console.WriteLine("For example [     DFS 8     ] means [ Solve 8 Queens with DFS ]");
                
                string[] read = Console.ReadLine().Split(' ');

                try
                {
                    input = read[0].Trim();
                    if (input != "")
                    {
                        dimension = Convert.ToInt32(read[1]);   
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                switch (input.ToUpper())
                {
                    case "":
                    {
                        break;
                    }
                    case "BFS":
                    {
                        solver = new BFSSolver(dimension);
                        if (solver.Solve())
                        {
                            Console.WriteLine("Solved in " + solver.ElapsedTime + " ms");
                            File.AppendAllText("log.txt","BFS:"+ dimension+":"+solver.ElapsedTime + "ms\r\n" );          
                        }
                        break;
                    }
                    case "DFS":
                    {
                        solver = new DFSSolver(dimension);
                        if (solver.Solve())
                        {
                            Console.WriteLine("Solved in " + solver.ElapsedTime + " ms");
                            File.AppendAllText("log.txt","DFS:"+ dimension+":"+solver.ElapsedTime + "ms\r\n" ); 
                        }
                        break;
                    }
                    case "UCS":
                    {
                        solver = new UCSSolver(dimension);
                        if (solver.Solve())
                        {
                            Console.WriteLine("Solved in " + solver.ElapsedTime + " ms");
                            File.AppendAllText("log.txt","UCS:"+ dimension+":"+solver.ElapsedTime + "ms\r\n" );
                        }
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
                }

            Console.WriteLine("----------------------------");

            } while (input != "");
        }
    }
}
