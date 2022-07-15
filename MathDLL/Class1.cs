using System;

namespace MathDLL
{
    public class MyMaths
    {
        public int a { get; set; }
        public int b { get; set; }

        public MyMaths(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Add()
        {
            return this.a + this.b;
        }
        public int Multiply()
        {
            return this.a * this.b;
        }
    }
}
