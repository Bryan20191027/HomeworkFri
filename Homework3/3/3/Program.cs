using System;

namespace _3
{
    public class Shape
    {
        
    }

    public interface func
    {
        public double getArea();
        public Boolean isLegal();
    }

    class Rectangle : Shape,func
    {
        private int length;
        private int width;

        public Rectangle(int a,int b){
            length = a;
            width = b;
        }

        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value > 0)
                {
                    length = value;
                }
            }
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value > 0)
                {
                    length = width;
                }
            }
        }

        public double getArea()
        {
            if (isLegal())
            {
                Console.WriteLine($"Rectangle {length * width}");
                return length * width;
            }
            else
            {
                Console.WriteLine("不合法，面积计算为0");
                return 0;
            }
        }

        public bool isLegal()
        {
            if (length > width)
                return true;
            else
                return false;
        }
    }

    class Triangle : Shape,func
    {
        private int edge1;
        private int edge2;
        private int edge3;

        public Triangle(int a,int b,int c)
        {
            edge1 = a;
            edge2 = b;
            edge3 = c;
        }

        public int Edeg1
        {
            get
            {
                return edge1;
            }

            set
            {
                if (value > 0)
                {
                    edge1 = value;
                }
            }
        }

        public int Edeg2
        {
            get
            {
                return edge2;
            }

            set
            {
                if (value > 0)
                {
                    edge2 = value;
                }
            }
        }

        public int Edeg3
        {
            get
            {
                return edge3;
            }

            set
            {
                if (value > 0)
                {
                    edge3 = value;
                }
            }
        }

        public double getArea()
        {
            if (isLegal())
            {
                int p = (edge1 + edge2 + edge3) / 2;
                double area = Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
                Console.WriteLine($"Triangle {area}");
                return area;
            }
            else
            {
                Console.WriteLine("不合法，面积计算为0");
                return 0;
            }
        }

        public bool isLegal()
        {
            if ((edge1 + edge2 > edge3) && (edge2 + edge3 > edge1) && (edge1 + edge3 > edge2))
                return true;
            else 
                return false;
        }
    }

    class Square : Shape,func
    {
        private int edge;

        public Square(int a)
        {
            edge = a;
        }
        public int Edge
        {
            get
            {
                return edge;
            }

            set
            {
                if (value > 0)
                {
                    edge = value;
                }
            }
        }

        public double getArea()
        {
            if (isLegal())
            {
                Console.WriteLine($"Square {edge * edge}");
                return edge * edge;
            }
            else
            {
                Console.WriteLine("不合法，面积计算为0");
                return 0;
            }
        }

        public Boolean isLegal()
        {
            return true;
        }
    }

    class main22
    {
        public static void Main(string[] args)
        {
            Square s = new Square(6);
            Console.WriteLine(s.getArea());
            Shape tempS;
            Random rd = new Random();
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                tempS = selectTheShape(rd.Next(3));
                if (tempS is Rectangle)
                    sum += ((Rectangle)tempS).getArea();
                else if (tempS is Triangle)
                    sum += ((Triangle)tempS).getArea();
                else if (tempS is Square)
                    sum += ((Square)tempS).getArea();
                else
                    continue;
            }
            Console.WriteLine();
        }

        public static Shape selectTheShape(int num)
        {
            Random rd = new Random();
            int a = rd.Next(1, 30);
            int b = rd.Next(1, 30);
            int c = rd.Next(1, 30);
            switch (num)
            {
                case(0):
                    return new Rectangle(a,b);
                case (1):
                    return new Triangle(a,b,c);
                case (2):
                    return new Square(a);
                default:
                    return null;
            }
        }
    }
}
