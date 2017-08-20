using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace han
{
    public class w2
    {
        public static void Main()
        {
            ////Section B. 1  
            //Console.WriteLine("takes a double precision number as input");
            //double input = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("prints the square root of the number:{0}", Math.Sqrt(input));

            ////2
            //Console.WriteLine("takes a double precision number as input");
            //double input = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("prints the square root of the number:{0:#.000}", Math.Sqrt(input));

            ////3
            //Console.Write("salary?");
            //double input = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("output is {0:#.00} ", input + input * 0.1 + input * 0.03);

            ////4
            //Console.Write("Centigrade?  ");
            //double input = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Fahrenheit is {0} ", input * 1.8 + 32);

            ////5
            //Console.Write("x?  ");
            //double input = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("y = 5 x2 – 4 x + 3 is {0} ", 5 * input * input - 4 * input + 3);

            //6
            //Console.Write("(x,y) coordinates of two points?  ");
            //Console.Write("x1?  ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("x2?  ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("y1?  ");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("y2?  ");
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("the distance between the two points is {0} ", Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

            ////7 8
            //Console.Write("kilometres?  ");
            //double km = Convert.ToDouble(Console.ReadLine());
            //double fare = 2.40 + km * 0.4;
            //Console.WriteLine("the total fare is {0:#.00} ", Math.Round(fare, 1, MidpointRounding.ToEven));

            ////9
            //Console.Write("kilometres?  ");
            //double km = Convert.ToDouble(Console.ReadLine());
            //double fare = 2.40 + km * 0.4;
            //double roundValue = Math.Ceiling(fare * 10) / 10;
            //Console.WriteLine("the total fare is {0} ", roundValue);

            //10
            //Console.Write("determining the area of a triangle,\n given the lengths of its three sides a, b and c.");
            //Console.Write("\n a?");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b?");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("c?");
            //double c = Convert.ToDouble(Console.ReadLine());
            //double s = (a + b + c) / 2;
            //Console.WriteLine("the area of a triangle is {0}", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));

            //Section C. 1
            //Console.WriteLine("Please type your name and gender (M or F assume capital letter)");
            //Console.Write("name?");
            //String name = Console.ReadLine();
            //Console.Write("gender?");
            //String gender = Console.ReadLine();

            //if (gender == "M" || gender == "m")
            //{
            //    Console.WriteLine("Good Morning, Mr.{0}", name);
            //}
            //else if (gender == "F" || gender == "f")
            //{
            //    Console.WriteLine("Good Morning, Ms.{0}", name);
            //}
            //else
            //{ Console.WriteLine("gender?"); }

            //2
            //Console.WriteLine("Please type your name, age and gender (M or F assume capital letter)");
            //Console.Write("name?");
            //String name = Console.ReadLine();
            //Console.Write("age?");
            //double age = Convert.ToDouble(Console.ReadLine());
            //Console.Write("gender?");
            //String gender = Console.ReadLine();

            //if ((age < 40 && age > 0) && (gender == "F" || gender == "f"))
            //{
            //    Console.WriteLine("Good Morning, Ms. {0}", name);
            //}
            //else if ((age > 40 && age < 120) && (gender == "F" || gender == "f"))
            //{
            //    Console.WriteLine("Good Morning, Aunty {0}", name);
            //}
            //else if ((age > 40 && age < 120) && (gender == "M" || gender == "m"))
            //{
            //    Console.WriteLine("Good Morning, Uncle {0}", name);
            //}
            //else if ((age < 40 && age > 0) && (gender == "M" || gender == "m"))
            //{
            //    Console.WriteLine("Good Morning, Mr. {0}", name);
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}

            ////3
            //Console.Write("mark?");
            //double mark = Convert.ToDouble(Console.ReadLine());
            //if (mark >= 80 && mark <= 100)
            //{
            //    Console.WriteLine("You scored {0} marks which is A grade.", mark);
            //}
            //else if (mark >= 60 && mark <= 79)
            //{
            //    Console.WriteLine("You scored {0} marks which is B grade.", mark);
            //}
            //else if (mark >= 40 && mark <= 59)
            //{
            //    Console.WriteLine("You scored {0} marks which is C grade.", mark);
            //}
            //else if (mark >= 0 && mark <= 40)
            //{
            //    Console.WriteLine("You scored {0} marks which is F grade.", mark);
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}

            ////4
            //Console.Write("kilometres?");
            //double km = Convert.ToDouble(Console.ReadLine());
            //km = Math.Ceiling(km * 10) / 10;

            //if (km <= 0.5)
            //{
            //    Console.WriteLine("fare = $ 2.40 (first 0.5 km)");
            //}
            //else if (km > 0.5 && km <= 9)
            //{
            //    double fare = 2.4 + (km - 0.5) * 10 * 0.04;
            //    Console.WriteLine("fare = $ 2.40 (first 0.5 km) + $0.04 per 100m (next 8.5 km) = {0:C}", fare);
            //}
            //else if (km > 9)
            //{
            //    double fare = 2.4 + 8.5 * 10 * 0.04 + (km - 9) * 10 * 0.05;
            //    Console.WriteLine("fare = $ 2.40 (first 0.5 km) + $0.04 per 100m (next 8.5 km)+ $0.05 per 100m (over 9 km)  = {0:C}", fare);
            //}

            ////5
            //Console.Write("Given a three-digit integer as input, number values from 100 to 999");
            //// Change input from string into double 
            //Console.Write("\nfirstDigit?");
            //double firstDigit = Convert.ToDouble(Console.ReadLine());
            //Console.Write("secondDigit?");
            //double secondDigit = Convert.ToDouble(Console.ReadLine());
            //Console.Write("thirdDigit?");
            //double thirdDigit = Convert.ToDouble(Console.ReadLine());
            //// the cube of input
            //double cube = Math.Pow(firstDigit, 3) + Math.Pow(secondDigit, 3) + Math.Pow(thirdDigit, 3);
            //// Change input from double into string
            //string digit1 = Convert.ToString(firstDigit), digit2 = Convert.ToString(secondDigit), digit3 = Convert.ToString(thirdDigit);
            //// Concatenate individual input
            //string digit4 = digit1 + digit2 + digit3;
            //// Change input from string into double, then we can use same data type in if else statement  
            //double digit = Convert.ToDouble(digit4);

            //if (cube == digit)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
        }
    }
}
