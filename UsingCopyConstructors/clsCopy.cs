using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCopyConstructors
{
    class clsCopy
    {
        public string ages, courses, sections, dates;
        public clsCopy(string a, string c, string s, string da)
        {
            ages = a;
            courses = c;
            sections = s;
            dates = da;
        }
        public clsCopy(clsCopy values)
        {
            ages = values.ages;
            courses = values.courses;
            sections = values.sections;
            dates = values.dates;

        }
    }
}
