using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_PasswordChecker
{
    internal class Program
    {
        /*
         * Ask user to enter password, and store
         * Ask user to enter password again, and store
         * Check if they are both contain something
           * If they are, print "Passwords match"
           * If they are not, print "Passwords do not match" 
           * If they are empty, print "Please enter a password
         */
        static void Main(string[] args)
        {
            string password, checkPassword;

            Console.Write("Enter a password: ");
            password = Console.ReadLine();

            Console.Write("Enter the password again: ");
            checkPassword = Console.ReadLine();

            if (!String.IsNullOrEmpty(password))
            {
                if (!String.IsNullOrEmpty(checkPassword))
                {
                    if (password.Length >= 6 && checkPassword.Length >= 6)
                    {

                        if (password.Equals(checkPassword))
                        {
                            Console.WriteLine("Passwords Matched!!");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter 6 or more characters!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a confirmation password");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password");
            }
        }
    }
}
