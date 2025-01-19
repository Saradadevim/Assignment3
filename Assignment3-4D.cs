namespace Assignment3_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // sort elements of the array in descending order.
            //getting user input as array size
            Console.Write("Enter the number of elements in the array: ");
            int size;

            //validating
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for the array size:");
            }

            // declaring the array
            int[] array = new int[size];

            // Getting array elements from the user with validation
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter  element  {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                    Console.Write($"Enter integer value for element {i + 1}: ");
                }
            }

            // loop for sorting using indices
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] < array[j])
                    {
                        // Swaping the elements
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            // Displaying the sorted array
            Console.WriteLine("Array elements in descending order:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
