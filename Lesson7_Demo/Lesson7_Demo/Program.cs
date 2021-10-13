using System;

namespace Lesson7_Demo
{
    class Program
    {
        private static int sumOfMin;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            sumOfMin = 14;
        }

        public void Sum()           //metode nav static, tāpēc nevar izmantot Main metodē
        {
            Console.WriteLine("Can I sum here?");

            StaticSum();
        }

        public static void StaticSum()
        {
            Console.WriteLine("Can I sum here?");
        }
    }
}
