using System.Runtime.ConstrainedExecution;

namespace Assignment3_3C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //separate odd and even integers in separate arrays.

            //declaring a variable
            int size;

            //getting user input for array size
            Console.Write("Enter array size: ");

            //Validating
            while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid Inuput!! Enter a Positive number: ");
            }

            //declaring variables for array
            int[] numbers = new int[size];
            int i;

            //loop to add the elements in the loop
            for (i = 0; i < size; i++)
            {
                Console.Write($"Element{i + 1}: ");

                //validating array elements
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid Input!! Enter a positive number. ");
                    Console.Write($"Element{i + 1}: ");
                }
            }

            //declaring array for saving even and odd numbers separately
            int[] oddNumbers = new int[numbers.Length];
            int[] evenNumbers = new int[numbers.Length];

            int evenCount = 0;  
            int oddCount = 0;

            //to check whether the numbers are even or not
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers[evenCount] = num;
                    evenCount++;
                }
                else
                {
                    oddNumbers[oddCount] = num;
                    oddCount++;
                }
            }

            // Displaying Even Numbers
            Console.WriteLine("\nEven Numbers in the array:");
            if (evenCount == 0)
            {
                Console.WriteLine("No even numbers found.");
            }
            else
            {
                for (i = 0; i < evenCount; i++)
                {
                    Console.Write(evenNumbers[i] + " ");
                }
            }

            // Displaying Odd Numbers
            Console.WriteLine("\n\nOdd Numbers in the array:");
            if (oddCount == 0)
            {
                Console.WriteLine("No odd numbers found.");
            }
            else
            {
                for (i = 0; i < oddCount; i++)
                {
                    Console.Write(oddNumbers[i] + " ");
                }
            }



            Console.WriteLine("\nPress any key to Exit...");
            Console.ReadLine();
        }
    }
}
