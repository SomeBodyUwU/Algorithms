namespace TestingConsoleApp.Alghoritms
{
    internal static partial class Algorithm
    {
        public static int BinarySearch(int[] integerArray, int target)
        {
            int arrayLength = integerArray.Length;
            int lowNumberIndex = 0;
            int highNumberIndex = arrayLength - 1;
            int middleNumberIndex;
            while (lowNumberIndex < highNumberIndex)
            {
                middleNumberIndex = (lowNumberIndex + highNumberIndex) / 2;

                if (integerArray[middleNumberIndex] > target)
                {
                    highNumberIndex = middleNumberIndex;
                }
                else if (integerArray[middleNumberIndex] < target)
                {
                    lowNumberIndex = middleNumberIndex;
                }
                else
                {
                    return middleNumberIndex;
                }
            }
            return -1;
        }
    }
}
