using System.Diagnostics;
using System.Linq;
using System;

namespace n_queens_solution.solvers
{
    public class DFSSolver : ISolver
    {
        private int count = 0;
        private int[] board;
        private Stopwatch stopWatch = new Stopwatch();
        public DFSSolver(int dimension = 8) => Dimension = dimension;
        public long ElapsedTime => stopWatch.ElapsedMilliseconds;
        public int Dimension { get; set; }

        public bool Solve()
        {
            stopWatch.Start();
            board = new int[Dimension];
            for (int i = 0; i < Dimension; i++)
            {
                board[i] = 0;
            }

            int[] result = DFS(board);
            stopWatch.Stop();

            return result != null;
        }

        private void Place(int clm)
        {
            board[count] = clm;
            count++;
        }

        private bool IsGoal()
        {
            return count == Dimension;
        }

        private void Unplace()
        {
            count --;
        }

        private bool IsSafe(int clm)
        {
            for (int i = 0; i < count; i++)
            {

                if ((board[i] == clm) || Math.Abs(clm - board[i]) == (count - i)) 
                    return false;
            }
            return true;
        }

        int[] DFS(int[] board)
        {
            if (IsGoal() == true)
            {
                return board;
            }
            else
            {
                for (int i = 0; i < Dimension; i++)
                {
                    if (IsSafe(i))
                    {
                        Place(i);
                        var res= DFS(board);
                        if (res != null)
                            return res;
                        Unplace();
                    }
                }

            }
            return null;
        }
    }
}