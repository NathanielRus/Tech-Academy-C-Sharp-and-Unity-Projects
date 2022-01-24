using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    public class Days
    {
        public DayOfWeek InDay { get; set; }
    }

    public enum DayOfWeek
    {
        None,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
