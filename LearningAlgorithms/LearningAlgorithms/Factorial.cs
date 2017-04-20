using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms
{
    class Factorial
    {
        public static int Compute(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Compute(n - 1);
        }
    }
}
