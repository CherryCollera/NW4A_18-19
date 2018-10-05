using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingParmeterizedConstructors
{
    class clsParameter
    {
        public string ages, courses, sections, dates;
        public clsParameter(string a, string c, string s, string da)
        {
            ages = a;
            courses = c;
            sections = s;
            dates = da;
        }
    }
}
