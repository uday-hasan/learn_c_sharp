using System;
namespace HelloWorld
{
    class Program
{
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 }; //int numbers = new int[] { 1, 2, 3, 4, 5 };

            int[3] ages = { 10, 20, 30 }; //int numbers = new int[5] { 1, 2, 3, 4, 5 };

            int[,] 2DArray = { { 1,2,3}, { 4,5,6} };
            // Single , means 2D array, double , means 3D array



            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            
    }
}
}