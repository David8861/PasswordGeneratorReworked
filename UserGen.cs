using System;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace Password_Generator
{
    public class UserGen
    {

        public static void Main(string[] args)
        {
            // Store user's first name in a string.
            string? firstname, savechoice;

            Console.WriteLine("What is your first name?\n");
            firstname = Console.ReadLine();

            // Create a string of characters to become the password.
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var customstring = new Char[5]; // Create a variable, specifying the length of the new string.
            Random randomstring = new Random(); // Create a random instance variable.

            for (int i = 0; i < customstring.Length; i++) // When the new character string is greater than 0, add one.
            {
                // Set the new random char to print another set of characters, until reaching the specified length.
                customstring[i] = characters[randomstring.Next(characters.Length)];

            }
            // Store a string of characters(password) in a variable.
            var finaluser = new String(customstring);

            // Concatenate user's firstname string with a random, 5 character string.
            Console.WriteLine("Here is your username: " + firstname + finaluser + "\n");

            Console.WriteLine("Care to save your new username?\n");
            savechoice = Console.ReadLine();

            if (savechoice == "yes")
            {


                // Create a file at the specified location.
                using (FileStream fs = File.Create("c:\\MyUsername.txt", 4096))
                {
                    // Create an integer containing username information.
                    byte[] info = new UTF8Encoding(true).GetBytes("Username: " + firstname + finaluser);

                    fs.Write(info, 0, info.Length); // Write the byte to the created file.


                    Console.WriteLine("Saved to your Desktop.\n");
                    Console.WriteLine("Exiting...");
                    Console.ReadLine();

                }



            }
            else if (savechoice != "y")
            {

                Console.WriteLine("Exiting...");
                Console.ReadLine();

            }
        }

    }
}
