using System.Diagnostics;

namespace n_queens_solution.solvers
{
    public class UCSSolver : ISolver
    {
        private Stopwatch stopWatch = new Stopwatch();
        public UCSSolver(int dimension = 0) => Dimension = dimension;
        public long ElapsedTime => stopWatch.ElapsedMilliseconds;
        public int Dimension { get; set; }

        public bool Solve()
        {
            stopWatch.Start();
            throw new System.NotImplementedException();
        }
    }
}