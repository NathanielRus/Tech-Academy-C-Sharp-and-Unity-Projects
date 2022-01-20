using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Assignment
{
    class Math
    {
        public void Operations(int UserIn1)
        {
            Console.WriteLine(UserIn1 / 2);
        }
        
        public void Operations(int DiffNum, int Hardnum)
        {
            Console.WriteLine(DiffNum * Hardnum);
        }

        public void OutArg(out int number)
        {
            number = 44;
        }

    }
}
