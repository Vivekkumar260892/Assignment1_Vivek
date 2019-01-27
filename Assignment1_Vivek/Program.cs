using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 11, b = 30;
            printPrimeNumbers(a, b);
            Console.ReadKey(true);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + rounding(r1, 2));
            Console.ReadKey(true);


            long n2 = 17;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.ReadKey(true);

            long n3 = 10001;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.ReadKey(true);

            int n4 = 6;
            printTriangle(n4);
            Console.ReadKey(true);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 8 };
            computeFrequency(arr);
            Console.ReadKey(true);

            /* write your self-reflection here as a comment 
            1- Got handson experience on Visual Studio IDE.
            2- Got exposure to basics of c# and coding in general.
            3- Learned programming concepts and their fundamental application.
            4- Learned how to present and prepare a proper flow of the program.
            5- Learned how to develop and use methods throughout the program having independent functionality in c# programming.
            6- Broke the program into simpler segments for efficient calculation.
            7- Learned how to convert data types i.e. String to int.
            8- Learned how to handle corner cases.
            */
        }
 //Soln 1
        /* This method is used to determine all the numbers which are prime from a given set */
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                //input a and b are passed in v and p
                int v, p;
                
                for (v = x; v <= y; v++)
                {
                    for (p = 2; p <= v; p++)
                 //If the number is divided by any number smaller than itself starting with 2 then break and number is not prime.
                 //If the loop completes and the number is only divisible by itself then the number is prime.
                    if (v % p == 0)

                    break;

                    if (v == p)

                        Console.WriteLine(+v + " " + "is a prime number between " + x + " " + "and" + " " + y);

                }


                //Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }
 //Soln 2

            /*This method is used give a solution from a given series*/
        public static double getSeriesResult(int n)
        {

            try
            {   //initializing all variables to 0.0
                //determining if number is even or odd
                //sum of odd series
                //sum of even series
                //total sum
                double f1 = 0.0;
                double f2 = 0.0;
                double f = 0.0;
                for (int i = 1; i <= n; i++)
                {     //logic for determining if a number is odd. If the case fails then number is even.
                    if (i % 2 != 0)
                    {
                        //odd part of the series
                        f1 = (f1 + Fact(i)) / (i + 1);

                    }
                    else
                    {
                        //even part of the series
                        f2 = -(f2 + (Fact(i) / (i + 1)));

                    }
                }
                f = f1 + f2;
                return f;


                // Write your code here

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }//end of getSeriesResult

        //Methd to calculate the factorial of a given number
        public static double Fact(double v1)
        {
            double xy = v1;
            //corner case
            if (xy == 0)

            {
                return 1;
            }
            else
            {
                for (double i = v1 - 1; i >= 1; i--)
                {
                    xy = xy * i;

                }
                return xy;
            }
        }
        //Method to round the digits to 2 decimal places
        public static decimal rounding(double input, int position)
        {
            decimal d1 = (decimal)input;
            return decimal.Round(d1, position);
        }
 //Soln 3

        /* This method is used to convert a number from decimal (base 10) to binary (base 2)*/
        public static long decimalToBinary(long quotient)
        {
            try
            {
                // Divide the given number by 2.
                // Get the quotient for the next step.
                // Get the remainder for the binary digit.
                // Repeat this until quotient gets to 0.

                string binarySoln = string.Empty;
                long remains = 0;
                while (quotient > 0)
                {
                    remains = quotient % 2;
                    quotient = quotient / 2;
                    binarySoln = remains.ToString() + binarySoln;
                }
                // Convert a string type to long type
                return Convert.ToInt64(binarySoln);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }
 //Soln 4
        /* This method is used to convert a number from binary (base 2) to decimal (base 10) */
        public static long binaryToDecimal(long n)
        {
            try
            {
                // 1) Start from the rightmost bit to the leftmost.
                // 2) Multiply each bit by 2^i where i starts from 0 and increases by 1 on every iteration.
                // 3) Finally add every result for the final result.

                long remains, baseNum = 1, decimalOutput = 0;
                while (n > 0)
                {
                    // %10 will give the rightmost bit of the number.
                    remains = n % 10;
                    // Multiply the rightmost bit with the base value also add it to the result.
                    decimalOutput = decimalOutput + (remains * baseNum);
                    // Dividing the number by 10 will take out the rightmost bit which is already in use.
                    n = n / 10;
                    baseNum = baseNum * 2;
                }
                return decimalOutput;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }
 //Soln 5
        public static void printTriangle(int n)
        {
            try
            {
                
                Console.WriteLine("\n A Triangle having " + n + " rows:");
                // Outer loop will take care of number of rows i.e. "n" in this case
                for (int i = 0; i < n; i++)
                {

                    // inner loop will take care of number spacing 
                   
                    for (int j = n - i; j > 1; j--)
                    {
                        // print number spacing
                        Console.Write(" ");
                    }

                    //  inner loop will handle number of columns 
                    for (int j = 0; j <= i; j++)
                    {
                        // printing the desired character output i.e. "*" 
                        Console.Write("* ");
                    }

                    // ending line after each row 
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
  //Soln6
        /* This method will calculate frequency of all the elements in the given array */
        public static void computeFrequency(int[] arr)
        {
            try
            {
                Console.WriteLine("Element Frequency");
                for (int i = 0; i < arr.Length; i++)
                {
                    // look to the left in the array if the number appeared already.
                    int used = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            used++;
                        }
                    }

                    // continue if the number occurs the first time
                    if (used == 0)
                    {
                        
                        int count = 1;

                        // look towards the right of the array for other occurances of the number
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                        //if the arrays match, then increment
                            if (arr[i] == arr[j]) count++;
                        }
                        Console.WriteLine(arr[i] + "      " + count);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

