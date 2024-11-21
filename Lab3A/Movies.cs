using System;

namespace Lab3A
{
    // The Movies class represents a movie in the media collection, 
    // inheriting from Media and implementing the IEncryptable interface for added security features.
    internal class Movies : Media, IEncryptable
    {
        // Properties to store the movie's title, author (director), and release year
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        /// <summary>
        /// Constructor to initialize a new Movie object with a title, release year, and author (director).
        /// </summary>
        /// <param name="title">The title of the movie</param>
        /// <param name="year">The release year of the movie</param>
        /// <param name="author">The director of the movie</param>
        public Movies(string title, int year, string author) : base(title, year)
        {
            // Set properties when creating a new movie
            Title = title;
            Year = year;
            Author = author;
        }

        /// <summary>
        /// Decrypt method that returns a readable string with the decrypted movie title,
        /// along with its release year and author (director).
        /// </summary>
        /// <returns>A formatted string with decrypted title, year, and author</returns>
        public string Decrypt()
        {
            // Call Encrypt first to encode, then decode back to the original with Rot13,
            // then format the result to show full movie details
            return $"Title: {Rot13(Encrypt())} ({Year}) \nAuthor: {Author}";
        }

        /// <summary>
        /// Encrypt method that uses the ROT13 algorithm to encode the movie title.
        /// </summary>
        /// <returns>The encrypted title of the movie</returns>
        public string Encrypt()
        {
            // Simply call Rot13 on the title to get an encoded version
            return Rot13(Title);
        }

        /// <summary>
        /// Helper method that performs ROT13 encryption or decryption. Since ROT13 is symmetric,
        /// applying it twice will return the original string, making it useful for both encoding and decoding.
        /// </summary>
        /// <param name="input">The string to be encrypted or decrypted</param>
        /// <returns>A string transformed by ROT13</returns>
        private string Rot13(string input)
        {
            // Convert the input string to a character array for in-place modification
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++) // Go through each character
            {
                char c = buffer[i]; // Get the current character
                if (c >= 'a' && c <= 'z') // Check if it's a lowercase letter
                {
                    // Rotate lowercase letters by 13 within alphabet bounds
                    buffer[i] = (char)('a' + (c - 'a' + 13) % 26);
                }
                else if (c >= 'A' && c <= 'Z') // Check if it's an uppercase letter
                {
                    // Rotate uppercase letters similarly
                    buffer[i] = (char)('A' + (c - 'A' + 13) % 26);
                }
            }
            // Return the newly encrypted/decrypted string
            return new string(buffer);
        }
    }
}
