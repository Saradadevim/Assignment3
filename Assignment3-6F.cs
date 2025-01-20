namespace Assignment3_6F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Delete an element at the desired position from an array

            // Declaring a sample array
            int[] numbers = { 1, 3, 5, 7, 9, 10 };

            // Display the original array
            Console.WriteLine("Original Array:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Get the position to delete
            Console.Write("Enter the position (0-based index) of the element to delete: ");
            int position;
            while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position >= numbers.Length)
            {
                Console.WriteLine("Invalid input! Please enter a valid index.");
            }

            // Create a new array with one less element
            int[] newNumbers = new int[numbers.Length - 1];

            // Copy elements to the new array, skipping the element at the given position
            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                if (i != position)
                {
                    newNumbers[j] = numbers[i];
                    j++;
                }
            }

            // Update the numbers array
            numbers = newNumbers;

            // Display the updated array
            Console.WriteLine("\nArray after deletion:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
