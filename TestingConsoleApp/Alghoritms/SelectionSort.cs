namespace TestingConsoleApp.Alghoritms
{
    // O(n^2) time complexity, two nested loops, each loop iterates n times
    internal static partial class Algorithm
    {
        internal static int[] SelectionSort(int[] inputArray)
        {
            int arrayLength = inputArray.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                int smallestNumber = inputArray[i]; // Assumption in this cycle
                int smallestNumberIndex = i;

                for (var j = i + 1; j < arrayLength; j++)
                {
                    if (inputArray[j] < smallestNumber)
                    {
                        smallestNumber = inputArray[j];
                        smallestNumberIndex = j;
                    }
                }

                if (smallestNumberIndex != i)
                {
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[smallestNumberIndex];
                    inputArray[smallestNumberIndex] = temp;
                }
            }
            return inputArray;
        }
    }
}
