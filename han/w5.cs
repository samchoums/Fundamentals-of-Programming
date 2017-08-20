using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace han
{
    class w5
    {
        public static void Main()
        {


        }

        //Section H. 1
        //public static int ReadInteger()
        //{
        //    string input;
        //    int num;

        //    do
        //    {
        //        Console.WriteLine("Please enter a interger");
        //        input = Console.ReadLine();

        //    } while (!Int32.TryParse(input, out num));

        //    Console.WriteLine(num);
        //    return num;

        //}

        //public static void H2()
        //{

        //    int[] arr = new int[3] { 1, 2, 3 };
        //    int[] arr2 = new int[4] { 3, 2, 6, 7 };

        //    PrintArray(arr2);

        //    PrintArray(arr);

        //}
        ////Write a static method PrintArray(int[] arr) that doesn’t return any value.
        ////This method should print out all the elements of an array to the console in any format that you prefer.

        //public static void PrintArray(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i]);
        //    }

        //    Console.WriteLine();
        //}

        //     public static void H3()
        //     {
        ////string s1 = "asdfgz";
        ////string s2 = "g";

        //string s1 = Console.ReadLine();
        //string s2 = Console.ReadLine();
        //Console.WriteLine(InString(s1, s2));
        //     }


        //     //static void Main(string InString)
        //     //{
        //      //   string call = InString(s1, s2);
        //     //}

        //     public static Boolean InString(string s1, string s2)  // method with static can be used in the entire object
        //     {

        //         Boolean check = true;

        //         for (int i = 0; i < s1.Length;i++)
        //         {

        //                 if (s1.Substring(i, s2.Length) == s2.Substring(0, s2.Length))
        //		{
        //			check = true;  
        //                     break;
        //		}
        //		else
        //		{
        //			check = false;
        //		}

        //         }

        //return check;

        //     }

        //     public static void H4()
        //     {
        //         string s1 = Console.ReadLine();
        //         string s2 = Console.ReadLine();
        //         FindWord(s1, s2);
        //     }

        //     public static int FindWord(string s1, string s2)
        //     {
        //         int count = -1; //If the word does not occur the return value should be –1.  
        //s1 = s1.ToLower(); // s1 is a storage of s1.ToLower()
        //         s2 = s2.ToLower();

        //         for (int i = 0; i < s1.Length; i++)
        //         {
        //             if (s1.Substring(i, s2.Length) == s2)
        //             {
        //                 count = i ;
        //                 break;    // stop counting after finding postion 
        //             }    
        //             else
        //             {
        //                 count = -1;
        //             }

        //}

        //Console.WriteLine(count);
        //         return count;   // must return to Findword 

        //      }

        //        public static void H5()
        //        {


        //            Console.WriteLine("input\t     output");

        //            hexHundred();

        //        }


        //		/*
        //        static string hexadecimal()
        //        {
        //            Console.WriteLine("input");
        //            int input = Convert.ToInt32(Console.ReadLine());

        //            string X = input.ToString("X");

        //            Console.WriteLine(X);


        //            return X;
        //        }

        //*/

        //		static string hexHundred()
        //        {

        //            int i;
        //			string Hex = "";
        //			for (i = 1; i <= 100; i++)
        //			{
        //				Hex = i.ToString("X");
        //				Console.WriteLine("{0}\t      {1}", i, Hex);
        //			}
        //                return Hex;
        //         }

        // public static void H6()
        // {

        //     Substitute("",'a','w');

        // }

        // public static string Substitute(string s, char c1, char c2)
        //{

        //     s = Console.ReadLine();

        //     s = s.Replace(c1,c2);
        //     Console.WriteLine(s);

        //     return s;


        // }

        //     public static void H7()
        //     {


        //         int[] A = new int[]{1,2,3};
        //h2.PrintArray(A);
        //         SetArray(A, 342);
        //         h2.PrintArray(A);
        //     }

        //     static void SetArray(int[] arr, int value)
        //     {

        //         for (int i = 0; i < arr.Length;i++)
        //         {
        //             arr[i] = value;
        //         }
        //     }


        //public static void H8()
        //{

        //    int[] A = new int[] { 1, 2, 3, 4, 5 };
        //    h2.PrintArray(A);

        //    int[] B = ResizeArray(A, 10);
        //    h2.PrintArray(B);

        //}

        //static int[] ResizeArray(int[] arr, int newSize)

        //{

        //    int[] newArray = new int[newSize];

        //    int min = Math.Min(newSize, arr.Length);

        //    for (int i = 0; i < min; i++)
        //    {
        //        newArray[i] = arr[i];
        //    }

        //    return newArray;

        //}

        //public static void H9()
        //{
        //    for (int i = 0; i <= 1000; i++)
        //    {
        //        if (IsPrime(i) == true)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        //static bool IsPrime(int n)
        //{
        //    bool Prime = true;
        //    if (n <= 1)
        //    {
        //        Prime = false;
        //    }

        //    for (int j = 2; j < n; j++)
        //    {

        //        if (n % j == 0)
        //        {
        //            Prime = false;
        //            break;
        //        }       /*
        //         deleted  this part 
        //         error
        //         else 
        //        {
        //            Prime = true;
        //            break;
        //        } For example, 9 wasn't divided by 2, then it will jump to else past, becoming true
        //         */
        //    }

        //    return Prime;
        //}

        //public static void H10()
        //{
        //    int[,] one = new int[,]
        //    {{1,2},
        //     {2,3},
        //     {3,4}};

        //    PrintMultiply(one);


        //    int[,] two = new int[,]
        //    {{5,2,4},
        //     {3,6,8}};

        //    PrintMultiply(two);


        //    int[,] newArray = MatrixMultiply(one, two);
        //    PrintMultiply(newArray);
        //}


        //static int[,] MatrixMultiply(int[,] A, int[,] B)
        //{
        //    int[,] newArray = new int[A.GetLength(0), B.GetLength(1)];

        //    for (int i = 0; i < A.GetLength(0); i++)  // y = 0,1,2
        //    {
        //        for (int row = 0; row < A.GetLength(0); row++)  // y = 0,1,2;
        //        {
        //            for (int col = 0; col < B.GetLength(0); col++)  // y = 0,1;
        //            {

        //                newArray[i, row] = newArray[i, row] + A[i, col] * B[col, row];  // A(0,0) * B(0,0) + A(0,1) * B(1,0) + A(0,2) * B(2,0);

        //            }
        //        }
        //    }

        //    return newArray;
        //}

        //static void PrintMultiply(int[,] A)
        //{
        //    Console.WriteLine("\n");
        //    for (int i = 0; i < A.GetLength(0); i++)  // 0,1,2
        //    {
        //        for (int j = 0; j < A.GetLength(1); j++) // 0,1
        //        {
        //            Console.Write(A[i, j] + "\t");
        //        }

        //        Console.WriteLine();

        //    }

        //}

        //      public static void H11()
        //      {

        //          double[] test = new double[] { 1.2, 2.3, 4.5 };

        //          double[] output = ProcessArray(test, Sqrt);    //sqrt(2)cannot convert from 'double' to 'w5.h11.DoubleOps'
        //	Print(output);

        //      }

        //delegate double DoubleOps(double x);

        //static double[] ProcessArray(double[] arr, DoubleOps ops)
        //{
        //          double[] newArr = new double[arr.Length];

        //	for (int i = 0; i < arr.Length; i++)
        //	{

        //              newArr[i] = ops(arr[i]);

        //	}

        //	return newArr;
        //}

        //static double Pow(double M)
        //      {
        //          return Math.Pow(M, 2);
        //      }

        //static double Sqrt(double M)
        //{
        //          return Math.Sqrt(M);
        //}

        //      static void Print(double[] arr)
        //      {
        //          for (int i = 0; i < arr.Length; i++)
        //          {
        //              Console.WriteLine(arr[i]);
        //          }

        //      }

    }
}
