using System;
using System.Drawing;

namespace Shapes
{
    public class Circle
    {
        public void Draw()
        {
            Pen p = new Pen(Color.Red);
        }
        double radius;
        public Circle()
        {
            radius = 0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * (radius * radius);
        }        
    }
}