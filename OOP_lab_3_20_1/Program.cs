using System;

namespace OOP_lab_3_20_1
{
    class Program
    {
        static void Main()
        {
            bool doubLetter = false;

            Console.Write("введiть рядок: ");

            string[] strs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Kiлькiсть слiв : {0}.", strs.Length);

            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j].Length > 1)
                {
                    for (int i = 1; i < strs[j].Length; i++)
                    {
                        if (strs[j][i] == strs[j][i - 1])
                        {
                            Console.WriteLine("Cлово з подвоєнням : {0}.", strs[j]);

                            strs[j] = null;

                            doubLetter = true;

                            break;
                        }
                    }
                }
            }
                
            if (!doubLetter) Console.WriteLine("Hемає слiв з подвоєнням.");

            foreach (string word in strs)
            {
                if (word != null)
                {
                    Console.Write(word + " ");
                }
            }

            Console.WriteLine();
        }

    }
}
