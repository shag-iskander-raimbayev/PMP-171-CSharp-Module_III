using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /*
         *  1. string[] args
         *  Совет: regions 
         *  2. unchecked / checked
         *  
         *  3. Массивы
         *  4. String
         */
        static void Main(string[] args)
        {
            #region Topic 1 - Command Line Arguments
            /*
            string[] adminPasswords = { "y2*3da", "67Yw1J*" };
            string[] userPasswords = { "12345", "123456" };

            string [] passwordInput = { args[0], args[1] };

            bool isPassedByUserPassword = false, isPassedByAdminPassword = false;

            if (adminPasswords.Contains(args[0]))
            {
                isPassedByAdminPassword = true;
            }
            else if (adminPasswords.Contains(args[1]))
            {
                isPassedByAdminPassword = true;
            }

            if (userPasswords.Contains(args[0]))
            {
                isPassedByUserPassword = true;
            }
            else if (userPasswords.Contains(args[1]))
            {
                isPassedByUserPassword = true;
            }

            if(isPassedByUserPassword && isPassedByAdminPassword)
            {
                Console.WriteLine("Welcome to SUPER-SECRET-PROGRAM");
            }
            */
            #endregion
            checked
            {
                int a = 100;
                sbyte b = 100;
                b = (sbyte)a;

                Console.WriteLine(b);

            }

            Console.ReadLine();
        }
    }
}
