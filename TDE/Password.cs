using System;
using System.Collections.Generic;
using System.Text;



namespace TDE
{
    public class Password
    {
        public static bool VerifyLength(string password)
        {
            if (password.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool VerifyNotNull(string password)
        {
            if (password != null && password != " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyUpper(string password)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c) == true)
                {
                    return true;
                }              
            
            }
            return false;
        }

        public static bool VerifyLower(string password)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool VerifyNum(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c) == true)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter at least an 8 character password with a capital letter, lowercase letter, number and no spaces.");

            bool go = true;

            while (go)
            {
                string input = Console.ReadLine();
                int ruleCount = 0;
                if (VerifyNum(input) == true)
                {
                    ruleCount++;
                    continue;
                }
                if (VerifyLength(input) == true)
                {
                    ruleCount++;
                    continue;
                }
                if (VerifyNotNull(input) == true)
                {
                    ruleCount++;
                    continue;
                }
                if (VerifyLower(input) == true)
                {
                    ruleCount++;
                    Console.WriteLine("Your password must have a lowercase number!");
                    go = true;
                }
                if (VerifyUpper(input) == true)
                {
                    ruleCount++;
                    continue;
                }
                if (ruleCount >= 3)
                {
                    Console.WriteLine("Password accepted!");
                }
                else
                {
                    Console.WriteLine("Try again.");
                    go = true;
                }
            }

        }
    }
}
