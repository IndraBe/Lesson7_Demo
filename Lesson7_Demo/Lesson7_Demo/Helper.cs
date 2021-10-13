using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Demo
{
    public static class Helper
    {
        public static int age;

        public static void Divide()
        {
            Console.WriteLine("hops");
        }
        public static bool IsValidEmailAddress(string email)
        {
            return email.Contains('@');
        }

        public static DateTime GetYesterday(this DateTime date)     //papildinātas DateTime klases funkcionālās iespējas
        {
            return date.AddDays(-1);
        }
    }
}
