namespace n_queens_solution.solvers
{
    public interface ISolver
    {
        int Dimension {get; set;}
        bool Solve();
        long ElapsedTime {get;}
    }
}