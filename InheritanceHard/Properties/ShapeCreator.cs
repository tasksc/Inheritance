using System;
namespace InheritanceHard
{
    public class ShapeCreator
    {
        public  void SetLength(double l)
        {
            length = l;
        }

        public void SetWidth(double w)
        {
            width = w;
        }

        public void SetRadius(double r)
        {
            radius = r;
        }
        public void SetHeight(double h)
        {
            height= h;
        }
        protected double length;
        protected double width;
        protected double height;
        protected double radius;
    }
}
