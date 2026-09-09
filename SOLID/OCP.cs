namespace SOLID.O
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public override double Area()
        {
            return Side * Side;
        }
    }

    public class Rectrange : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }


    public class ShapeCalculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.Area();
            /*switch (shape)
            {
                case Square square:
                    return square.Side * square.Side;
                case Rectrange rectrange:
                    return rectrange.Width * rectrange.Height;
                case Circle circle:
                    return Math.PI * circle.Radius * circle.Radius;
                default:
                    throw new NotSupportedException("Shape not supported");
            }*/
        }
    }
}
