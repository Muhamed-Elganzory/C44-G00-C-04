using System.ComponentModel;

namespace C44_G00__C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            Console.WriteLine("Enter x1:");
            double.TryParse(Console.ReadLine(), out double x1);

            Console.WriteLine("Enter y1:");
            double.TryParse(Console.ReadLine(), out double y1);

            Console.WriteLine("Enter x2:");
            double.TryParse(Console.ReadLine(), out double x2);

            Console.WriteLine("Enter y2:");
            double.TryParse(Console.ReadLine(), out double y2);

            Console.WriteLine("Enter x3:");
            double.TryParse(Console.ReadLine(), out double x3);

            Console.WriteLine("Enter y3:");
            double.TryParse(Console.ReadLine(), out double y3);

            double slope1 = (y2 - y1) / (x2 - x1);

            double slope2 = (y3 - y2) / (x3 - x2);

            if (slope1 == slope2)
            {
                Console.WriteLine("The points lie on the same straight line.");
            }
            else
            {
                Console.WriteLine("The points do NOT lie on the same straight line.");
            }
            #endregion

            #region 2- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined.
            /*
                - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
                - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
                - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
                - If the worker takes more than 5 hours, they are required to leave the company. 
                To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
             */

            double actualHours = 0;
            bool parsed = false;

            do
            {
                Console.WriteLine("Please enter the number of actual hours worked...");
                parsed = double.TryParse(Console.ReadLine(), out actualHours);
            } while (!parsed || actualHours < 0);

            switch (actualHours)
            {
                case > 2 and <= 3:
                    Console.WriteLine("Highly efficient worker.");
                    break;
                case > 3 and <= 4:
                    Console.WriteLine("They are instructed to increase their speed.");
                    break;
                case > 4 and <= 5:
                    Console.WriteLine("They require training to increase their speed.");
                    break;
                case > 5:
                    Console.WriteLine("They are required to leave the company.");
                    break;
            }
            #endregion

            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                sum += Numbers[i];
            }
            Console.WriteLine($"The sum of all elements in the array is: {sum}");
            #endregion

            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            int[] arr1 = { 1, 2, 3, 4, 5 };
                int[] arr2 = { 6, 7, 8, 9, 10 };

                int[] mergedArray = new int[arr1.Length + arr2.Length];
                int index = arr1.Length + arr2.Length;

                int x = 0, y = 0, z = 0;

            for (int i = 0; i < mergedArray.Length; i++)
            {
                if (x >= arr1.Length)
                {
                    mergedArray[z++] = arr2[y++];
                }
                else if (y >= arr2.Length)
                {
                    mergedArray[z++] = arr1[x++];
                }
                else if (arr1[x] < arr2[y])
                {
                    mergedArray[z++] = arr1[x++];
                }
                else
                {
                    mergedArray[z++] = arr2[y++];
                }
            }

            for (int i = 0; i < mergedArray.Length; i++)
                {
                    Console.Write(mergedArray[i] + " ");
                }
            #endregion
        }
    }
}
