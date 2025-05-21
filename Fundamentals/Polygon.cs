namespace Fundamentals.Helpers
{
    class Triangle : Polygon
    {
        private double tBase;
        private double height;

        public Triangle(double newBase, double newHeight)
        {
            tBase = newBase;
            height = newHeight;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"The triangle area is {tBase * height / 2}");
        }
    }


    class Square : Polygon
    {
        double side;

        public Square(double newSide)
        {
            side = newSide;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"The square area is {side * side}");
        }
    }


    class Rectangle : Polygon
    {
        double width;
        double height;

        public Rectangle(double newWidth, double newHeight)
        {
            width = newWidth;
            height = newHeight;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"The rectangle area is {width * height}");
        }
    }


    abstract class Polygon
    {
        public abstract void CalculateArea();
    }
}