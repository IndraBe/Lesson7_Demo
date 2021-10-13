using System;

//https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0

namespace Lesson7_Demo
{
    class Program
    {
        private static int sumOfMin;        //beigs eksistēt, kad izslēgs programmu. Viens uz visu programmu. Automātiski programmas beigās iznīcināts.



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            sumOfMin = 14;


            DateTime currentDate = DateTime.UtcNow;

            currentDate.GetYesterday();


            Helper.Divide();
            Helper.age = 14;

            //Garbage Collector

            int sum = 48;
           
            if (true)
            {
                sum++;
            }

            else
            {
                sum--;
            }
        }               //beidz savu darbību pēc šī un var tikt uznīcināts

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
