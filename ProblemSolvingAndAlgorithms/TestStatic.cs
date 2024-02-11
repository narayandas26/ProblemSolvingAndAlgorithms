using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingAndAlgorithms
{
    public class TestStatic
    {
        static int i;
        static TestStatic()
        {
            i = 10;
        }

        public TestStatic()
        {
            if (i == 0)
            {
                i = 5;
            }
        }

        public void Print()
        {
            if (i == 5)
                i = 6;
            Console.WriteLine(i);
        }
    }
}
