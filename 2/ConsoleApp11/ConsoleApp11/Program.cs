using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Петров", "Гусев", "Антоненко", "Данилков", "Афанасьев", "Смирнов" };

            for (int i = 1; i < array.Length; i++)
            {
                string cur = array[i];
                int j = i;
                while (j > 0 && String.Compare(cur, array[j - 1]) < 0)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
