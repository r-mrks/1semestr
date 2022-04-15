using System;
using System.Data;

namespace Laba7
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var date = new Date(10, 1, 2001);
            Console.WriteLine(date.GetWeekDay());
            

        }
    }
}