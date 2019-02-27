using System;
namespace InheritanceHard
{
    public class Calculation:ShapeCreator,IAreaCalculcation,IVolumeCalculation
    {

        public double area;
        public double volume;
        public double getArea1()
        {
            area = length * width;
            Console.WriteLine($"Area is {area}");
            return area;
        }

        public double getArea2()
        {
            area = 3.14 * radius * radius;
            Console.WriteLine($"Area is {area}");
            return area;

        }

        public double getVolume()
        {
            volume = area * height;
            Console.WriteLine(volume);
            return volume;
        }
    }
}
