using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string wordLower = word.ToLower();
            int wordLenght = word.Length;
            char[] chArray = wordLower.ToCharArray();
            String str = "";


            for (int i = 0; i < wordLenght; i++)
            {
                for (int j = 0; j < wordLenght; j++)
                {
                    if ((wordLenght - 1) != j && i == j)
                    {
                        continue;
                    }
                    else if (i != j && chArray[i] == chArray[j])
                    {
                        str += ")";
                        break;
                    }
                    else if ((wordLenght - 1) == j)
                        str += "(";
                }
            }
            Console.Write(str);
            Console.ReadKey();
        }
    }
}