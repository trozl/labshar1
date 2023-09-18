using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labshar1
{
    class TherdNum
    {
        
        private double abs, x;

        public TherdNum(double xinput)
        {
            x = xinput;
        }
        public void CalcAbs()
        {
            abs = Math.Abs(x*5 - 4);
        }
        public void ShowAbs()
        {
            Console.WriteLine($"Вычиcление выражения 5x-4 при х = {x}");
            Console.WriteLine($"Abs = {abs}");
        }
    }
}
