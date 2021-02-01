using System;

namespace StringSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter string to be sorted");
                string input = Console.ReadLine();
                stringsort stringSort = new stringsort();
                int[] ascciArray = stringSort.GetAsciiArrayofString(input);
                Console.Write(stringSort.SortArray(ascciArray, ascciArray.Length, 97, 122));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
