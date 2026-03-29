namespace TestingConsoleApp.Helpers
{
    internal static class ConsoleHelper
    {
        internal static void PrintArray(int[] array)
        {
            string[] elements = array.Select(x => x.ToString()).ToArray();
            Console.Write(String.Join(", ", elements));
        }
    }
}
