using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    internal interface IShape
    {
        //public string color { get; set; }
        //public int frameThickness { get; set; }
        public int getVertexAmount();
        public void roll();
        public IShape whatsHigher(IShape shape1, IShape shape2) {

            int vertex1 = shape1.getVertexAmount();
            int vertex2 = shape2.getVertexAmount();
            if (vertex1>vertex2)
            {
                return shape1;
            }
            else 
            {
                return shape2;
            }
        }
    }
    public class Rectangle : IShape
    {
        public int length;
        public int width;
        int IShape.getVertexAmount()
        {
            return 4;
        }
        void IShape.roll() { Console.WriteLine("Rectangle cant roll"); }
    }

    public class Circle : IShape
    {
        public int radius;
        int IShape.getVertexAmount() { return 0; }
        void IShape.roll() { Console.WriteLine("wiiii "); }
    }
    public class Elipse:IShape
    {
        private int radius;
        private int secondRadius;
        public Elipse(int radius,int secondRadius)
        {
            this.radius = radius;
            this.secondRadius = secondRadius;
        }
        int IShape.getVertexAmount() { return 0; }
        void IShape.roll() { Console.WriteLine("wiiii "); }
    }
    public class Triangle : IShape
    {
        public int height;
        public int width;
        int IShape.getVertexAmount() { return 3; }
        void IShape.roll() { Console.WriteLine("triangle cant roll "); }
    }

    public class Moon : IShape
    {
        private int radius;
        public Moon(int radius)
        {
            this.radius = radius;
        }
        public int getDiameter()
        {
            return radius * 2;
        }
        int IShape.getVertexAmount() { return 2; }
        void IShape.roll() { Console.WriteLine("wiiiii "); }
    }

}
