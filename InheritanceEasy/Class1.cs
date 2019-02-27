using System;
namespace InheritanceEasy
{
    public class Class1
    {
        public string Name = "Akshay";
        public string Task = "C # Task";
        public virtual void WriteClassCont()
        {
            Console.WriteLine("***************************");
            Console.WriteLine(Name);
            Console.WriteLine(Task);
            Console.WriteLine("***************************");
        }
    }
}
