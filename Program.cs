using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constoverl
{
    internal class ADD
    {
        int x, y;
        double f;
        string s;
        public ADD(int a, double b)
        {
            x = a;
            f = b;
        }
        public ADD(int a, string b)
        {
            y = a;
            s = b;
        }
        public void show()
        {
            Console.WriteLine("first constructor  + |int +float|:[0]", +(x + f));
        }
        public void show1()
        {
            Console.WriteLine("second constructor  + |int +string|:" + (y + s));
        }
    }
    class over
    {
        static void Main()
        {
            ADD g = new ADD(10, 20.2);
            g.show();
            ADD q = new ADD(50,"roll number " );
            q.show1();
        }

    }
}
