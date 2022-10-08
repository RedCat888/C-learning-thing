using System;

namespace C_learning_thing
{
    class Program
    {

        static void Main(string[] args)




        {

            Console.WriteLine("Sign Up:");

            Console.WriteLine("Enter Username:");

            string User1 = Console.ReadLine();

            //Line above reads user input and stores as string

            Console.WriteLine("Confirm?");

            Console.WriteLine(User1);

            Console.WriteLine("yes or no?");

            string ConfirmUsername = Console.ReadLine();

            string yes = "yes";


            if (ConfirmUsername == yes)

            {

                Console.WriteLine("Enter Password:");

                string user1Pass = Console.ReadLine();

                Console.WriteLine("Re-enter password to confirm:");

                string user1passwordconfirm = Console.ReadLine();

                if (user1Pass == user1passwordconfirm)
                {

                    Console.WriteLine("Password Confirmed. Account Created");

                }
                else
                {

                    Console.WriteLine("Password not matching. Retry");

                    string user1passwordconfirm2 = Console.ReadLine();

                    if (user1Pass == user1passwordconfirm2)
                    {

                        Console.WriteLine("Password Confirmed. Account Created");

                    }
                    else
                    {
                        Console.WriteLine("Too many attempts. Restart the program to try again.");
                    }

                }

            }
            else
            {

                Console.WriteLine("Please enter your username again");
                string User11 = Console.ReadLine();

                //Line above reads user input and stores as string

                Console.WriteLine("Confirm?");

                Console.WriteLine(User11);

                Console.WriteLine("yes or no?");

                string ConfirmUsername2 = Console.ReadLine();


                if (ConfirmUsername2 == yes)

                {

                    Console.WriteLine("Enter Password:");

                    string user1Pass = Console.ReadLine();

                    Console.WriteLine("Re-enter password to confirm:");

                    string user1passwordconfirm = Console.ReadLine();

                    if (user1Pass == user1passwordconfirm)
                    {

                        Console.WriteLine("Password Confirmed. Account Created");

                    }
                    else
                    {

                        Console.WriteLine("Password not matching. Retry");

                        string user1passwordconfirm2 = Console.ReadLine();

                        if (user1Pass == user1passwordconfirm2)
                        {

                            Console.WriteLine("Password Confirmed. Account Created");

                        }
                        else
                        {
                            Console.WriteLine("Too many attempts. Restart the program to try again.");
                        }

                    }

                }
                else
                {

                    Console.WriteLine("Too Many Attempts. Restart the program to try again.");
                }
            }

        }
    }
}