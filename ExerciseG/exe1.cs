using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseG
{
    class exe1
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Enter a phrase : ");
            s = Console.ReadLine();
            int total = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'a' || s[i] == 'A')
                {
                    total++;
                }
                else if (s[i] == 'e' || s[i] == 'E')
                {
                    total++;
                }
                else if (s[i] == 'i' || s[i] == 'I')
                {
                    total++;
                }
                else if (s[i] == 'o' || s[i] == 'O')
                {
                    total++;
                }
                else if (s[i] == 'u' || s[i] == 'U')
                {
                    total++;
                }

            }
            Console.WriteLine("Total Vowels : {0}", total);
                
        }
    }
}
