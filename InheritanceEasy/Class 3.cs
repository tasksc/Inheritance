using System;
namespace InheritanceEasy
{
    public class Class3:Class1
    {
   public new  string Name = "C # Task ";
  public new string Task = "Inheritance";
        public override void WriteClassCont()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Task);
        }


    }

}
