using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2_Assignment
{
    public class Math
    {
        
        public int Add(int userIn1, int userIn2)
        {
            int res = userIn1 * userIn2;
            return res;
        }

        public int userIn1 { get; set; }
        public int userIn2 { get; set; }
    }
}
