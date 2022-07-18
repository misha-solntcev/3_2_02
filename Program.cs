using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 2
Дана строка.Словом текста считается любая последовательность букв русского
алфавита; между соседними словами - не менее одного пробела, за последним словом -
точка. Найти и сохранить в строке те слова, которые встречаются в последовательности
по одному разу. Все остальные слова удалить. */

namespace _3_2_02
{
    internal class Program
    {
        static string SplitString(string myString)
        {
            char[] sep = { ' ', '.' };
            string[] myWord = myString.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            string newString = "";            
            for (int i = 0; i < myWord.Length; i++)
            {                
                Console.WriteLine($"i = {i}");
                int count = 0;
                for (int j = 0; j < myWord.Length; j++)
                {
                    Console.WriteLine($" j = {j}");
                    if (myWord[j] == myWord[i])
                        count++;                    
                }
                if (count == 1)
                    newString += myWord[i] + " ";
            }
            return newString;
        }
        static void Write(string newString)
        {
            Console.WriteLine(SplitString(newString));
        }
        
        static void Main(string[] args)
        {
            string myString = "дом пол потолок дом потолок.";
            Write(myString);
            Console.ReadKey();
        }
    }
}
