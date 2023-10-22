//Stina Hedman 
//NET23

namespace OOPPolymorphism
{
    public class Geometri 
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Rektangel : Geometri
    {
        public double width { get; set; }
        public double height { get; set; }
        
        public Rektangel(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return width * height;
        }
    }

    public class Fyrkant : Geometri
    {
        public double width { get; set; }
        public double height { get; set; }

        public Fyrkant(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }

    public class Cirkel : Geometri
    {
        public double rad { get; set; }

        public Cirkel(double radius)
        {
            rad = radius;
        }

        public override double Area()
        {
            return (rad * rad * Math.PI);
        }
    }

    public class Paralellogram : Geometri
    {
        public double height { get; set; }
        public double width { get; set; }

    public Paralellogram(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public override double Area()
        { 
            double a = height * width;
            return a;
        }
    }

    public class Ellips : Geometri
    {
        public double aAxis { get; set; }
        public double bAxis { get; set; }

        public Ellips(double axis1, double axis2)
        {
            aAxis = axis1;
            bAxis = axis2;
        }

        public override double Area()
        {
            double a = Math.PI * aAxis * bAxis;
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Geometri> shapes = new List<Geometri>();
            shapes.Add(new Rektangel(2, 2));
            shapes.Add(new Fyrkant(4, 5));
            shapes.Add(new Cirkel(1));
            shapes.Add(new Paralellogram(5, 8));
            shapes.Add(new Ellips(1,5));

            foreach (Geometri shape in shapes)
            {
                Console.WriteLine($"Area {shape.GetType().Name} : {shape.Area()}");
            }
        }
    }
}