using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart;

            do
            {
                Console.WriteLine("Please enter a word: ");
                string word = Console.ReadLine().ToLower();
                int vowelSpot = Findvowel(word);

                if (vowelSpot == 0)
                {
                    Console.WriteLine(word + "way");
                }
                else
                {
                    string x = word.Substring(vowelSpot);
                    string y = word.Substring(0, vowelSpot);

                    Console.WriteLine(x + y + "ay");
                }
                Console.WriteLine("Do you wish to continue? (Y or N");
                restart = Console.ReadLine();


                
            }while (restart.ToLower() == "y");

                      


        }
        public static int Findvowel(string word)

        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < word.Length; i++) {

                if (vowels.Contains(word[i]))
                {
                    return i;
                }

            }
            return -1;
        }
    }
}

