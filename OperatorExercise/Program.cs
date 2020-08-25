using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;



            //Exercise1
            // Console.WriteLine ($"{(a)/(b) is {quotient} remainder {remainder}'');
            Console.WriteLine(a + "/" + b + " is " + quotient + " remainder " + remainder + " ");


            Console.WriteLine("..............................................................");

            //Exercise2
            var radius = 20;
            var pi = 3.16;
            var areaofCircle = pi * (radius * radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {areaofCircle}");


            Console.WriteLine("..............................................................");

            //Exercise3
            var i = 3;
            var j = 4;
            var k = ++i * j++;


            Console.WriteLine(k);

        }
    }
}
