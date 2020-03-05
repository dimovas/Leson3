using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing ts = new Testing(5, 10, "point1");
            ts.SimpleVars();
            ts.ScoperVar(2);
        }
    }
}
