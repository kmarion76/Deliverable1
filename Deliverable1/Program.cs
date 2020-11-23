using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please create a password");
            Console.WriteLine("Password must contain:");
            Console.WriteLine("One lower case letter");
            Console.WriteLine("One upper case letter");
            Console.WriteLine("At least 7 characters");
            Console.WriteLine("No more than 12 characters");
            Console.WriteLine("An exclamation point (!)");

            string password = Console.ReadLine();
            if (password.Length >= 7 && password.Length <=12)
            {
                if (password.Any(char.IsUpper))
                        {
                        if (password.Any(char.IsLower))
                            {
                                if (password.Contains("!"))
                                    {
                                        Console.WriteLine("Password valid and accepted");
                                    }

                            }
                        }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
