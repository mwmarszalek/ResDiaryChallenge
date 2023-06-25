public class Program
{
    /// <summary>
    /// Divides an input array into N equally sized subarrays.
    /// </summary>
    /// <param name="arr">The input array to be divided.</param>
    /// <param name="N">The number of subarrays to create.</param>
    /// <returns>A list of subarrays.</returns>
    public static List<List<int>> GroupArrayElements(int[] arr, int N)
    {
        // Check the length of the input array
        int length = arr.Length;

        // Calculate the size of each subarray by dividing the length by N
        int subArraySize = length / N;

        // Calculate the remainder to determine if an extra element should be added to the last subarray
        int remainder = length % N;

        // Initialize the result list to store the subarrays
        List<List<int>> result = new List<List<int>>();

        // Initialize the index to track the position in the input array
        int index = 0;

        // Iterate through N subarrays
        for (int i = 0; i < N; i++)
        {
            // Determine the actual size of the current subarray
            int size = subArraySize;

            // Add an extra element to the subarray if it's part of the remainder
            if (remainder > 0)
            {
                size++;
                remainder--;
            }

            // Extract the subarray and convert it to a list
            List<int> subArray = arr[index..(index + size)].ToList();

            // Add the subarray to the result list
            result.Add(subArray);

            // Move the index to the next set of elements
            index += size;
        }

        // Return the resulting list of subarrays
        return result;
    }

    static void Main(string[] args)
    {
        // Create sample input array
        int[] arr = { 1, 2, 3, 4, 5 };

        // Define the number of subarrays to create
        int N = 3;

        // Divide the array into subarrays using GroupArrayElements function
        List<List<int>> result = GroupArrayElements(arr, N);

        // Create the output string with subarrays formatted as arrays
        string output = "[" + string.Join(", ", result.Select(subArray => "[" + string.Join(", ", subArray) + "]")) + "]";

        // Print the resulting array of arrays
        Console.WriteLine(output);
    }
}
