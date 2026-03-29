namespace TestingConsoleApp.Helpers
{
    internal static class ConsoleHelper
    {
        internal static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(String.Concat(item, ", "));
            }
        }
    }
}
