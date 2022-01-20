using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class Math
    {
        public int Add(int userIn)
        {
            return userIn + 12;
        }

        public decimal Add(decimal decIn)
        {
            return decIn + 5.75M;
        }

        public int Add(string strIn, int userIn)
        {
            int intIn = Convert.ToInt32(strIn);
            int newInt = intIn * userIn / 2;
            return newInt;
        }
    }
}
