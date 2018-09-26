/*
 Завдання 6. 
 Дано два рядки. 
Необхідно з першого рядка видалити всі символи, які зустрічаються в рядку 2. 
Вивести одержаний рядок, а також статистику по обробці: 
	-кількість видалених символів усього,
	-кількість видалених входжень кожного символа
	-кількість символів, яка залишилась в рядку.
 */

using System;
using System.Linq;


namespace _06_two_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntDel = 0;
            int cntSmb = 0;
            string text1 = "Zero, one, two, three, four, five";
            string text2 = ",o";
            Console.WriteLine($"\tBefore\ntext1:\t{text1}");
            Console.WriteLine($"text2:\t{text2}\n- - - - - -");
            foreach (char c in text1)
            {
                if (text2.Contains(c))
                {
                    while (text1.IndexOf(c) > -1)
                    {
                        text1 = text1.Remove(text1.IndexOf(c), 1);
                        ++cntSmb;
                        ++cntDel;
                    }
                    if (cntSmb > 0)
                    {
                        Console.WriteLine($"{c} - {cntSmb}");
                        cntSmb = 0;
                    }
                }
            }
            Console.WriteLine($"Delete total symbols:\t{cntDel}\nRemains symbols:\t{text1.Length}");
            Console.WriteLine($"\n\tAfter\ntext1:\t{text1}");
        }
    }
}
