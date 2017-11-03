using System.Collections.Generic;
namespace n_queens_solution.solvers
{
    public class Node
    {
        public List<Node> Childs {get; private set;}
        public short?[] Model {get; private set;}


    }
}