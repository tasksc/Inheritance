using System;
using InheritanceEasy;

namespace InheritanceMedium
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Class1 a = new Class1();
            Class1 b = new Class2();
            Class1 c = new Class3();

            a.WriteClassCont();
            b.WriteClassCont();
            c.WriteClassCont();
          
        }
    }
}
