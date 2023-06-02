using System.Reflection.Metadata.Ecma335;

namespace C__gr3_part1_HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the Largest Value out of three...");
            LargestOfThree(1, 5, 3);

            Console.WriteLine("\n************************\n");

            Console.WriteLine("Finding the Largest Value out of three...");
            int res = LowestOfThree(1, 5, 3);
            Console.WriteLine("{0} is the lowest value", res);

            Console.WriteLine("\n************************\n");

            Console.WriteLine("Finding the closest number to 20...");
            Console.WriteLine("The result is {0}", ClosestTo20());

            Console.WriteLine("\n************************\n");

            Console.WriteLine("Calculating the sum of the array elements...");
            SumOfArrayElements();

            Console.WriteLine("\n************************\n");

            Console.WriteLine("Finding the largest element in the array...");
            LargestArrayElement();
        }

        public static void LargestOfThree (int i1, int i2, int i3)
        {
            if ((i1 >= i2) && (i1 >= i3))
                Console.WriteLine("{0} is the largest value", i1);
            else if ((i2 >= i1) && (i2 >= i3))
                Console.WriteLine("{0} is the largest value", i2);
            else
                Console.WriteLine("{0} is the largest value", i3);
        }

        public static int LowestOfThree (int i1, int i2, int i3)
        {
            if ((i1 <= i2) && (i1 <= i3))
                return i1;
            else if ((i2 <= i1) && (i2 <= i3))
                return i2;
            else
                return i3;
        }

        public static int ClosestTo20 ()
        {
            Console.Write("Please enter the first number: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int i2 = Convert.ToInt32(Console.ReadLine());

            int t1 = i1 - 20;
            int t2 = i2 - 20;
            if (t1 < 0)
                t1 *= -1;
            if (t2 < 0)
                t2 *= -1;

            if (t1 == t2)
            {
                if (i1 != i2)
                {
                    Console.WriteLine("Both numbers are equaly close to 20, still returning 0 cause I have to return something, even if numbers are not the same");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Returning 0 as both numbers are the same");
                    if (i1 == 0)
                        Console.WriteLine("Also apparently they both are equal to 0");
                    return 0;
                }
            }
            else if (t1 < t2)
            {
                if (i1 == 0)
                    Console.WriteLine("Returning 0, but it actually is the value of the closest number to 20");

                return i1;
            }
            else
            {
                if (i2 == 0)
                    Console.WriteLine("Returning 0, but it actually is the value of the closest number to 20");

                return i2;
            }
        }

        public static void SumOfArrayElements()
        {
            int[] someArray = { 2, 3, -2, -3, 7 };
            int sumOfElements = 0;

            Console.Write("The elements of the array:");

            foreach (int n in someArray)
            {
                Console.Write(" {0}", n);
                sumOfElements += n;
            }

            Console.WriteLine("\nThe sum of the array elements is: {0}", sumOfElements);
        }

        public static void LargestArrayElement()
        {
            int[] someArray = { 2, 11, -2, -11, 7 };
            int largestElement = someArray[0];

            Console.Write("The elements of the array:");

            foreach (int n in someArray)
            {
                Console.Write(" {0}", n);

                if (n > largestElement)
                    largestElement = n;
            }

            Console.WriteLine("\nThe largest array elements is: {0}", largestElement);
        }
    }
}