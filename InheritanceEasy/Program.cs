using System;

namespace InheritanceEasy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Class1 aks = new Class1();
            Class2 aks1 = new Class2();
            Console.WriteLine(aks.Name);
            Console.WriteLine(aks1.Name);
            Class1 aks3 = new Class2();
            aks3.WriteClassCont();
        }
    }
}
