using System.Diagnostics;

namespace n_queens_solution.solvers
{
    public class BFSSolver : ISolver
    {
        private Node root;
        private Stopwatch stopWatch = new Stopwatch();
        public BFSSolver(int dimension = 8) => Dimension = dimension;
        public long ElapsedTime { get => stopWatch.ElapsedMilliseconds; }
        public int Dimension { get; set; }

        public bool Solve()
        {
            throw new System.NotImplementedException();
        }
    }
}