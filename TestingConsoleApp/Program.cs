using TestingConsoleApp.Alghoritms;
using TestingConsoleApp.Helpers;

namespace TestingConsoleApp;

static class Program
{
    public static void Main(string[] args)
    {
        var binarySearchResult = Algorithm.BinarySearch(new int[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 7);
        Console.WriteLine(binarySearchResult.ToString());

        var resultArray = Algorithm.SelectionSort(new int[] { 5, 3, 8, 1, 2 });
        ConsoleHelper.PrintArray(resultArray);
    }
}
