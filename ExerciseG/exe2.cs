using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseG
{
    class exe2
    {
        static void Main()
        {
            string s;
            Console.Write("Enter a string : ");
            s = Console.ReadLine();

            string add = "";

            Console.WriteLine("{0}", s);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                add = add + s[i];
            }

            if (s == add)
            {
                Console.WriteLine("The string you entered is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string you entered is not a palindrome.");
            }
            version2();
        }

        static void version2()
        {
            string s;
            string back="";
            Console.Write("Enter a string for version 2: ");
            s = Console.ReadLine();
            s = s.ToLower();
            char[] c = new char[] { ' ', ',', '.','\"','\'' };
            string[] add = s.Split(c);
            string result=""; 
            for (int i = 0; i <= add.Length - 1; i++)
            {
                if (add[i] != " ")
                {
                    result = result + add[i];
                }
                
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                back = back + result[i];
            }

            if (result == back)
            {
                Console.WriteLine("The string you entered is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string you entered is not a palindrome.");
            }









        }


    }
}
