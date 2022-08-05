using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface ITrolleyDAO
    {
        List<TrolleyProblem> LoadAllProblems();
    }
}