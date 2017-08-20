using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace han
{
    class w4
    {
        public static void Main()
        {

            //Section F. 3
            //Console.WriteLine("input a string and test if the word is a palindrome\t");
            //string input = Console.ReadLine();
            //input = input.Replace(" ", "").Replace(".", "").ToLower();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input.Substring(i, 1) == input.Substring(input.Length - i - 1, 1))
            //    {
            //        Console.WriteLine("the word is a palindrome: {0}\t", input.Substring(0, input.Length));
            //        break;
            //    }
            //    else if (input.Substring(i, 1) != input.Substring(input.Length - i - 1, 1))
            //    {
            //        Console.WriteLine("the word is not a palindrome");
            //        break;
            //    }
            //}

            //4
            //int i;
            //string input = Console.ReadLine();
            //string[] s = input.Split(' ');

            //for (i = 0; i < s.Length; i++)
            //{
            //    Console.Write("{0} ", s[i].Substring(0, 1).ToUpper() + s[i].Substring(1, s[i].Length - 1));
            //}

            //         //5
            //         string[] Name = new string[3] { "Zoe", "Venkat", "Mary" };
            //         int[] Mark = new Int32[3] { 70, 29, 75 };
            //         Array.Sort(Name, Mark); //names alphabetically.
            //         //Array.Sort(Mark,Name); //descending order
            //         //Array.Reverse(Mark);
            //         //Array.Reverse(Name);

            //         int i;
            //         // int j;
            //         //int temp;
            //         /* 
            //            for (i = 0; i <= Mark.Length - 1; i++)
            //            {
            //               for (j = i + 1; j < Mark.Length; j++)
            //                {
            //                    if(Mark[i] < Mark[j])
            //                    {
            //                        temp = Mark[i];
            //                        Mark[i] = Mark[j];
            //                        Mark[j] = temp;                                
            //                    }    
            //                }
            //            }
            //*/
            //         Console.WriteLine("Name\t Mark\t");
            //         for (i = 0; i <= Mark.Length - 1; i++)
            //         {
            //             Console.WriteLine("{0}\t {1}", Name[i], Mark[i]);

            //         }

            //6
            //Console.WriteLine("enter a matriculation number");
            //int i;
            //string matri;
            //int sum = 0;
            //int remainder;
            //string checksum = "";
            //int j = 6;

            //matri = Console.ReadLine().ToUpper();

            //for (i = 1; i < matri.Length - 1; i++)  //A"00000"X
            //{
            //    int ch = Convert.ToInt32(matri.Substring(i, 1));///////
            //    sum = sum + ch * j; ///////
            //    if (j >= 2)
            //    {
            //        j--;
            //    }
            //}

            //remainder = sum % 5;

            //if (remainder <= 4 && remainder >= 0)
            //{
            //    if (remainder == 0)
            //    {
            //        checksum = "O";///////////
            //    }
            //    else if (remainder == 1)
            //    {
            //        checksum = "P";
            //    }
            //    else if (remainder == 2)
            //    {
            //        checksum = "Q";
            //    }
            //    else if (remainder == 3)
            //    {
            //        checksum = "R";
            //    }
            //    else if (remainder == 4)
            //    {
            //        checksum = "S";
            //    }

            //}

            //if (matri.Length != 7)
            //{
            //    Console.WriteLine("it’s invalid");
            //}
            //else if (checksum == matri.Substring(matri.Length - 1, 1))
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}

            //Section G. 1
            //string[] month = new string[4] { "Jan", "Feb", "Mar", "Apr" };
            //int[] sales = new int[4];
            //int i;
            //int sum = 0;

            //for (i = 0; i < 4; i++)/////
            //{
            //    Console.WriteLine(month[i]);
            //    sales[i] = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + sales[i];
            //}


            //for (i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("\n{0}\t{1} ", month[i], sales[i]);
            //}

            //Console.WriteLine("\nMaximum Sales:{1:C}, Minimum Sales:{2:C}, average:{0:c}", sales.Average(), sales.Max(), sales.Min());

            //2
            //int i;
            //int j;
            //int temp;



            //         int[] num = new int[5];
            //         for (i = 0; i < num.Length; i ++)
            //         {
            //	num[i] = Convert.ToInt32(Console.ReadLine());
            //         }


            //         for (i = 0; i < num.Length - 1; i++)
            //   {
            //             for (j = i + 1; j < num.Length; j++)
            //	   {
            //                 if(num[i] < num[j])
            //		   {
            //                     temp = num[i];
            //                     num[i] = num[j];
            //                     num[j] = temp;    
            //		   }    
            //	   }
            //   }


            //for (i = 0; i < num.Length; i++)
            //{
            //             Console.Write("\t{0}",num[i]);
            //}

            //3
//            // How does computer know when should stop if it doesn't know the number of students and the number of subject?

//            int[,] score = new int[3, 2]  //row = 3 ; col = 2, two dimension [3, 2], three.. [3, 2, 6]
//                /*
//                 int[,] array2D = new int[4,2]  
//                 { { 1, 2 }, 
//                 { 3, 4 }, 
//                 { 5, 6 },
//                 { 7, 8 } };
           
                 
//                 int[, ,] array3D = new int[2,2,3] 
//                 { { { 1, 2, 3 }, { 4, 5, 6 } }, 
//                 { { 7, 8, 9 }, { 10, 11, 12 } } }; 
            
//*/
//                {{20, 89},
//                {42, 88},
//                {35, 67}};
//            string[] student = new string[] { "A", "B", "C" };

//            int total;
//            int avg;
//            int subSum = 0;




//            Console.WriteLine("Student Subject1 Subject2 Total   Avg");

//            for (int i = 0; i < student.Length; i++)
//            {
//                Console.Write("  {0}\t", student[i]);
//                total = 0;
//                avg = 0;
//                for (int j = 0; j < 2; j++)
//                {
//                    total = total + score[i, j];
//                    avg = total / 2;
//                    Console.Write("  {0}\t", score[i, j]);
//                }

//                Console.WriteLine("   {0}\t   {1}", total, avg);
//            }

//            //GetLength(0) = row ,GetLength(1) = col
//            /*
//                {{20, 89},
//                {42, 88},
//                {35, 67}};

//              */

//            Console.Write("Average per subject:  ");
//            for (int row = 0; row < score.GetLength(1); row++)  // x = 0,1
//            {
//                for (int col = 0; col < score.GetLength(0); col++) //y = 0,1,2
//                {
//                    subSum = subSum + score[col, row];
//                    // sub1sum = (0,0) + (1,0) + (2,0)

//                }
//                Console.Write("{0:#.00000} ", subSum / score.GetLength(0));
//            }



        }
    }
}
