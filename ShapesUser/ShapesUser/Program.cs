namespace ShapeUser
{
    using System;

    using Shapes;

    public class ShapeUser
    {
        public static void Main()
        {
            Circle c = new Circle(1.0F);
            Console.WriteLine("Area of Circle(1.0) is {0}", c.Area());
        }
    }    
}
