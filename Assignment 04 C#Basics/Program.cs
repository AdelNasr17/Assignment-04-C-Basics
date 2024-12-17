namespace Assignment_04_C_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q13 : Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write(" Please Enter a String  : ");
            //string? Input = Console.ReadLine();

            //for (int i = Input.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(Input[i]);
            //}



            #endregion

            #region Q14 : Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write(" Please Enter a Integer : ");
            //bool flag = int.TryParse(Console.ReadLine(), out int num);

            //if (flag)
            //{
            //    string IntConvertString = num.ToString();
            //    for (int i = IntConvertString.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(IntConvertString[i]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input ");
            //}
            #endregion

            #region Q15 : Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write(" Please Enter The Start : ");
            //int.TryParse(Console.ReadLine(), out int Start);
            //Console.Write(" Please Enter The End : ");
            //int.TryParse(Console.ReadLine(), out int End);

            //for (int i = Start; i <= End; i++)
            //{
            //    int count = 0;

            //        for (int j = 2; j < i; j++)
            //        {

            //            if (i % j == 0)
            //            {
            //                count++;
            //                  break;
            //            }  

            //        }
            //        if( count ==0 & i!=1)
            //        {
            //            Console.WriteLine(i);
            //        }
            //}



            #endregion

            #region Q16 : Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write(" Please Enter A decimal number :  ");
            //int DecimalNumber = int.Parse(Console.ReadLine());

            //string Result = "";

            //if (DecimalNumber == 0)
            //{
            //    Console.WriteLine(" Binary : 0 ");
            //    return;
            //}

            //while (DecimalNumber > 0)
            //{

            //    Result = (DecimalNumber % 2) + Result;
            //    DecimalNumber /= 2;

            //}
            //Console.WriteLine($" Binary : {Result}");

            #endregion

            #region Q17 : Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter The point 1 (x1 y1):");
            //Console.Write(" X1 :");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write(" Y1 :");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The point 2 (x2 y2):");
            //Console.Write(" X2 :");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write(" Y2 :");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The point 3 (x3 y3):");
            //Console.Write(" X3 :");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write(" Y3 :");
            //double y3 = double.Parse(Console.ReadLine());

            //double slope1 = (y2 - y1) / (x2 - x1);
            //double slope2 = (y3 - y2) / (x3 - x2);

            //if (slope1 == slope2)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}



            #endregion

            #region Q18 : Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            ///*-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            // To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard. */


            //// The Answer :
            //Console.Write(" Please Enter the time taken to complete the task ( in Hours ) : ");
            //double TimeTake = double.Parse(Console.ReadLine());

            //switch (TimeTake)
            //{
            //    case >= 2 and < 3 :
            //        Console.WriteLine(" The worker is  highly efficient.");
            //        break;
            //    case >= 3 and < 4:
            //        Console.WriteLine(" The worker is instructed to increase their speed.");
            //        break;
            //    case >= 4 and < 5:
            //        Console.WriteLine(" The worker is provided with training to enhance their speed. ");
            //        break;
            //    case >= 5 :
            //        Console.WriteLine("The worker is required to leave the company. ");
            //        break;
            //}

            #endregion


        }
    }
}
