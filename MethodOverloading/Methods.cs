using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool TorF)
        {
            int answer = num1 + num2;   

            if (TorF && answer > 1)
            {
                return $"{answer} dollars";
            }
            else if (TorF && answer == 1)
            {
                return $"{answer} dollar";
            }
            else if (TorF && answer < 1)
            {
                return $"{answer} dollars";
            }
            else
            {
                return answer.ToString();
            }
        }
    }
}
