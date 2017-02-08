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
            int total = 0, numa=0,nume=0,numi=0,numo=0,numu=0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'a' || s[i] == 'A')
                {
                    total++;
                    numa++;
                }
                else if (s[i] == 'e' || s[i] == 'E')
                {
                    total++;
                    nume++;
                }
                else if (s[i] == 'i' || s[i] == 'I')
                {
                    total++;
                    numi++;
                }
                else if (s[i] == 'o' || s[i] == 'O')
                {
                    total++;
                    numo++;
                }
                else if (s[i] == 'u' || s[i] == 'U')
                {
                    total++;
                    numu++;
                }

            }
            Console.WriteLine("Total Vowels : {0} \nA: {1}\nE: {2}\nI: {3}\nO: {4}\nU: {5}", total,numa,nume,numi,numo,numu);
                
        }
    }
}
