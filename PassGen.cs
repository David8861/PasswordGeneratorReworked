using System;
using System.IO;
using System.Text;

namespace PasswordGeneratorReworked
{
    public class PassGen
    {

        public static void Main(string[] args)
        {
            // Create a string of characters to become the password.
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            var customstring = new char[15]; // Create a variable, specifying the length of the new string.
            var character = new Random(); // Create a random instance variable.

            for (int i = 0; i < customstring.Length; i++) // When the new character string is greater than 0, add one.
            {
                // Set the new random char to print another set of characters, until reaching the specified length.
                customstring[i] = characters[character.Next(characters.Length)];
            }
            // Store a string of characters(password) in a variable.
            var finalString = new String(customstring);

            // Prints the string of characters.
            Console.WriteLine(finalString);

            string? savechoice;

            Console.WriteLine("Care to save your new password?\n");
            savechoice = Console.ReadLine();

            if (savechoice == "yes")

                // Create a file at the specified location.
                using (FileStream fs = File.Create("c:\\MyPassword.txt", 4096))
                {
                    // Create an integer containing username information.
                    byte[] info = new UTF8Encoding(true).GetBytes("Password: " + finalString);

                    fs.Write(info, 0, info.Length); // Write the byte to the created file.


                    Console.WriteLine("Saved to your Desktop.\n");
                    Console.WriteLine("Exiting...");
                    Console.ReadLine();

                }

            else if (savechoice != "yes")
            {
                Console.WriteLine("Exiting...");
                Console.ReadLine();
            }
        }
    }

}
