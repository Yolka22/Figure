using System;

namespace Figure
{
    internal class Program
    {
        private class Figure
        {
            protected string name;

            public Figure(string name)
            {
                this.name = name;
            }

            protected double area;

            public double Area
            {
                get { return area; }
                set { area = value; }
            }

            public virtual void calculate()
            { }

            public virtual void Print()
            { Console.WriteLine(name); Console.WriteLine("Area " + Area); Console.WriteLine(); }
        }

        private class rectangle : Figure
        {
            protected int a, b;

            public rectangle(string name, int a, int b) : base(name)
            {
                this.a = a; this.b = b;
            }

            public override void calculate()
            {
                Area = a * b;
            }

            public override void Print()
            {
                Console.WriteLine($"A={a},B={b}");
                base.Print();
            }
        }

        private class Circle : Figure
        {
            protected int r;

            public Circle(string name, int r) : base(name)
            {
                this.r = r;
            }

            public override void calculate()
            {
                Area = (r * r) * Math.PI;
            }

            public override void Print()
            {
                Console.WriteLine($"r={r}");
                base.Print();
            }
        }

        private class Right_triangle : Figure
        {
            protected int a, b;

            public Right_triangle(string name, int a, int b) : base(name)
            {
                this.a = a; this.b = b;
            }

            public override void calculate()
            {
                Area = (a * b) * 0.5;
            }

            public override void Print()
            {
                Console.WriteLine($"A={a},B={b}");
                base.Print();
            }
        }

        private static void Main(string[] args)
        {
            rectangle Rectangle = new rectangle("rectangle", 12, 10);
            Circle circle = new Circle("circle", 5);
            Right_triangle right_triangle = new Right_triangle("right_triangle", 5, 10);

            Figure[] figures = new Figure[] { Rectangle, circle, right_triangle };

            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].calculate();
                figures[i].Print();
            }

            Console.ReadLine();
        }
    }
}