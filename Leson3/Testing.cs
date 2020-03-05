using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson3
{
    class Testing
    {
        int x, y;
        string name;
        public Testing(int x, int y, string name)
            {
            this.x = x;
            this.y = y;
            this.name = name;
            }
        public void SimpleVars()
        {
            int x, s;
            int y = 0, u = 77;
            float w1 = 0f, w2 = 5.5f, w3 = w1 + w2 + 125.25f;
            int z = new int();
            x = y + u;
            if (x > 5) s = 4;
            for (x = 1; x < 5; x++) s = 5;
        }

        public void ScoperVar(int x)
        {
            int y = 77; 
            string s = name;
            if (s=="point1")
            {
                int u = 5;
                int v = u + y;
                x += 1;
                Console.WriteLine("y = {0}; u = {1}; v = {2}; x = {3}",y,u,v,x);
            }
            else
            {
                int u = 7;
                int v = u + y;
                Console.WriteLine("y = {0}; u = {1}; v = {2}",y,u,v);
            }
            int i;
            long sum = 0;
            for ( i = 1; i < x; i++)
            {
                sum += i;
            }
            Console.WriteLine("x = {0}; sum = {1}",x,sum);
        }
    }
}
