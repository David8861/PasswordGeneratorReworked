using System;

namespace PasswordGeneratorReworked
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a string for program.
            string? username;

            // Input prompt
            Console.WriteLine("Enter 'username' or 'password' to generate. Enter 'e' to exit.\n");

            // Collect user input.
            username = Console.ReadLine();

            if (username == "username")
            {

                Console.WriteLine("Generating...\n");
                // If the user selects username, direct them to username gen class.
                UserGen.Main(args);

            }

            if (username == "password")
            {
                Console.WriteLine("Generating...\n");
                // If the user selects password, direct them to password gen class.
                PassGen.Main(args);

            }
            else if (username == "e")
            {
                // Exits program on 'e' press.
                Console.WriteLine("Exiting...");


            }
        }


    }
}
