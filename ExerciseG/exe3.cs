using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseG
{
    class exe3
    {
        static void Main()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine();
            string[] s = input.Split(' ');
            string result = "";
            string total="";
            for (int i = 0; i <= s.Length - 1; i++)
            {
                result = s[i];
                string upper = result[0].ToString().ToUpper();
                string sub=result.Remove(0, 1);
               
                total += sub.Insert(0,upper)+" ";
            }

            Console.WriteLine("Title Case String : {0}",total);
        }
    }
}
