using System;

namespace Lab3A
{
    /// <summary>
    /// The Book class represents a book in the media collection, inheriting from the Media class
    /// and implementing the IEncryptable interface for encryption and decryption functionalities.
    /// </summary>
    internal class Book : Media, IEncryptable
    {
        // Properties to store the book's title, author, and year of publication
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        /// <summary>
        /// Constructor to initialize a new Book object with a title, year, and author.
        /// </summary>
        /// <param name="title">The title of the book</param>
        /// <param name="year">The year the book was published</param>
        /// <param name="author">The author of the book</param>
        public Book(string title, int year, string author) : base(title, year)
        {
            Title = title; // Set the book's title
            Year = year;   // Set the book's publication year
            Author = author; // Set the book's author
        }

        /// <summary>
        /// Encrypts the title of the book using the ROT13 algorithm.
        /// ROT13 shifts each letter 13 positions in the alphabet, so applying it twice gives the original text.
        /// </summary>
        /// <returns>The encrypted title of the book</returns>
        public string Encrypt()
        {
            return Rot13(Title); // Encrypt the book title using ROT13
        }

        /// <summary>
        /// Decrypts the title of the book and returns a formatted string with the book's title, year, and author.
        /// </summary>
        /// <returns>A string with the decrypted title, year, and author</returns>
        public string Decrypt()
        {
            // Decrypt the title by first encrypting it, then decrypting it again with ROT13
            return $"Title: {Rot13(Encrypt())}, ({Year}) \nAuthor: {Author}";
        }

        /// <summary>
        /// A helper method to perform the ROT13 encryption or decryption.
        /// ROT13 shifts each letter of the input by 13 positions in the alphabet (a simple cipher).
        /// </summary>
        /// <param name="input">The string which should be encrypted or decrypted will be passed in the parameter</param>
        /// <returns>The transformed string after applying ROT13</returns>
        private string Rot13(string input)
        {
            char[] buffer = input.ToCharArray(); // Convert input string to a character array for manipulation
            for (int i = 0; i < buffer.Length; i++) // Loop through each character in the array
            {
                char c = buffer[i]; // Get the current character
                if (c >= 'a' && c <= 'z') // Check if the character is a lowercase letter
                {
                    // Apply ROT13 to lowercase letters
                    buffer[i] = (char)('a' + (c - 'a' + 13) % 26);
                }
                else if (c >= 'A' && c <= 'Z') // Check if the character is an uppercase letter
                {
                    // Apply ROT13 to uppercase letters
                    buffer[i] = (char)('A' + (c - 'A' + 13) % 26);
                }
            }
            return new string(buffer); // Return the new string after ROT13 transformation
        }
    }
}
