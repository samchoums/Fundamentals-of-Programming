using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace han
{
    class w3
    {
        public static void Main()
        {
            ////Section D. 1
            //Console.WriteLine("enter an integer number");
            //int input;
            //do
            //{
            //    input = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter an integer number again");
            //} while (input != 88);
            //Console.WriteLine("Lucky you…");

            //2
            //Console.Write("input two numbers A and B.\t");
            //Console.WriteLine("A?");
            //int A = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("B?");
            //int B = Convert.ToInt32(Console.ReadLine());

            //int HCF = 0;
            //int LCM;
            //int C = A * B;

            //do
            //{
            //    if (A > B)
            //    {
            //        A = A - B;
            //        HCF = A;
            //    }
            //    else if (B > A)
            //    {
            //        B = B - A;
            //        HCF = B;
            //    }
            //} while (A != B);
            //LCM = C / HCF;
            //Console.WriteLine("HCF = {0}, LCM = {1}", HCF, LCM);

            //3
            //Random r = new Random();
            //int value = r.Next(0, 10);

            //int guess;
            //int i = 0;

            //Console.WriteLine("thinks of an integer between 0 and 9 ");

            //do
            //{
            //    guess = Convert.ToInt32(Console.ReadLine());

            //    if (value != guess)
            //    {
            //        Console.WriteLine("Try again");
            //    }
            //    i = i + 1;
            //} while (value != guess);


            //if (i == 2)
            //{
            //    Console.WriteLine("You are a Wizard");
            //}
            //else if (i > 2 && i <= 5)
            //{
            //    Console.WriteLine("You are a good guess");
            //}
            //else if (i > 5)
            //{
            //    Console.WriteLine("You are lousy!");
            //}

            //Console.WriteLine("congratulate!, you took {0} times to make the guess", i);

            //4
            //Console.Write("input a number\t");
            //int N = Convert.ToInt32(Console.ReadLine());

            //Random r = new Random();//////////
            //double G = r.Next(1, N);/////////

            //do
            //{
            //    G = (G + N / G) / 2;
            //} while (Math.Abs(G * G - N) > 0.00001);

            //Console.WriteLine("square root is {0:#.000}", G);

            //       // Section E. 1
            //       Console.Write("Given a number");
            //       int input = Convert.ToInt32(Console.ReadLine());
            //       int i;
            //       int f = 1;

            //       /*  for ( i = 1; i <= input; i++)
            //       {
            // f = f * i;

            //} */

            //       for (i = input; i >= 1; i--)
            //       {
            //           f = f * i;
            //       }

            //       Console.WriteLine("factoria {0}", f);

            //2
            //int i;
            //for (i = 1; i <= 10; i++)
            //{
            //    double inverse = 1.0 / i;
            //    double squareRoot = Math.Sqrt(i);
            //    double square = Math.Pow(i, 2);
            //    Console.WriteLine("NO={0:#.0}, INVERSE={1:0.000}, SQUAR ROOT={2:#.000}, SQUARE={3:#.0} ", i, inverse, squareRoot, square)
            //}

            //3
            //Console.Write("Given an integer\t");
            //Boolean prime = true;
            //int input = Convert.ToInt32(Console.ReadLine());
            //int i = input - 1;
            //do
            //{
            //    if (input % i == 0)
            //    {
            //        prime = false;
            //        break;
            //    }
            //    i--;
            //} while (i > 1); o

            //if (prime == true)
            //{
            //    Console.WriteLine("Prime number");
            //}
            //else
            //{
            //    Console.WriteLine("Not Prime number");
            //}

            //4
            //Console.Write("Given an integer\t");
            //int input = Convert.ToInt32(Console.ReadLine());
            //int i;
            //int sum = 0;

            //for (i = input - 1; i >= 1; i--)
            //{
            //    if (input % i == 0)

            //    {
            //        sum = sum + i;
            //    }
            //}

            //if (sum == input)
            //{
            //    Console.WriteLine("perfect number");
            //}
            //else
            //{
            //    Console.WriteLine("not perfect number");
            //}

            ////5
            //int i;
            //int j;
            //Boolean prime = true;

            //for (i = 10000; i >= 5; i--)
            //{
            //    prime = true;

            //    for (j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            prime = false;
            //            break;
            //        }
            //    }

            //    if (prime == true)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //6
            //         int i = 0;
            //         for (i = 1000; i >= 1; i--)
            //         {
            //             int sum = 0;
            //             for (int j = i - 1; j >= 1; j--)
            //             {

            //                 if (i % j == 0)

            //                 {
            //                     sum = sum + j;
            //                 }
            //             }
            //             if (sum == i)
            //             {
            //                 Console.WriteLine(i);
            //             }
            //         }
            //         /*
            //int i;
            //         int j; 

            //for (i = 1000; i > 0; i--)
            //{             
            //             for (j = 1; j < i; j++)
            //             {
            //                 j = j + 1;
            //	}
            //         }

            //         if (j == i)
            //	{
            //		Console.WriteLine(i);

            //	}
            //         */

            //Section F. 1

            //Console.Write("phrase?");
            //string input = Console.ReadLine();
            //int sumA = 0, sumE = 0, sumI = 0, sumO = 0, sumU = 0;
            //int Total = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input.Substring(i, 1) == Convert.ToString('a') || input.Substring(i, 1) == Convert.ToString('A'))
            //    {
            //        sumA = sumA + 1;
            //    }
            //    else if (input.Substring(i, 1) == Convert.ToString('e') || input.Substring(i, 1) == Convert.ToString('E'))
            //    {
            //        sumE = sumE + 1;
            //    }
            //    else if (input.Substring(i, 1) == Convert.ToString('i') || input.Substring(i, 1) == Convert.ToString('I'))
            //    {
            //        sumI = sumI + 1;
            //    }
            //    else if (input.Substring(i, 1) == Convert.ToString('o') || input.Substring(i, 1) == Convert.ToString('O'))
            //    {
            //        sumO = sumO + 1;
            //    }
            //    else if (input.Substring(i, 1) == Convert.ToString('u') || input.Substring(i, 1) == Convert.ToString('U'))
            //    {
            //        sumU = sumU + 1;
            //    }
            //    Total = sumA + sumE + sumI + sumO + sumU;
            //}
            //Console.WriteLine("Total vowels:{0}\t,A:{1},E:{2},I:{3},O:{4},U:{5}", Total, sumA, sumE, sumI, sumO, sumU);

            //2
            //Console.WriteLine("input a string and test if the word is a palindrome\t");
            //string input = Console.ReadLine();

            //// odd even  ABBA, ""747, radar, madam

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input.Substring(i, 1) == input.Substring(input.Length - i - 1, 1))
            //    {
            //        Console.WriteLine("the word is a palindrome");
            //        break;
            //    }
            //    else if (input.Substring(i, 1) != input.Substring(input.Length - i - 1, 1))
            //    {
            //        Console.WriteLine("the word is not a palindrome");
            //        break;
            //    }
            //}


        }
    }    
}
