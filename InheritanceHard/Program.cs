using System;

namespace InheritanceHard
{
    class MainClass
    {
        public static void Main(string[] args)
        {
         Console.WriteLine("A Class Can only Inherit from one Base Class but can inherit multiple Interfaces");
            Calculation calc = new Calculation();
            calc.SetLength(12);
            calc.SetWidth(14);
            calc.getArea1();
            calc.SetRadius(4);
            calc.SetHeight(1);
            calc.getArea2();
            calc.getVolume();

        }
    }
}
