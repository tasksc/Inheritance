using System;
namespace InheritanceEasy
{
    public class Class2:Class1
    {
        public new string Name = "C # Task ";
        public new string Task = "Inheritance";
         public  void WriteClassCont()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Task);
        }


    }


}
