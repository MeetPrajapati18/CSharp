using System;

namespace Lab3A
{
    // The Songs class represents a song in the media collection.
    // It inherits from the Media class and implements IEncryptable for encryption features.
    internal class Songs : Media, IEncryptable
    {
        // Properties to store song-specific details: title, artist, release year, and album
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Album { get; set; }

        /// <summary>
        /// Constructor to initialize a new Song object with title, year, album, and artist.
        /// </summary>
        /// <param name="title">The title of the song</param>
        /// <param name="year">The release year of the song</param>
        /// <param name="album">The album the song belongs to</param>
        /// <param name="artist">The artist of the song</param>
        public Songs(string title, int year, string album, string artist) : base(title, year)
        {
            // Assign properties based on parameters when creating a new song
            Title = title;
            Year = year;
            Artist = artist;
            Album = album;
        }

        /// <summary>
        /// Decrypt method that provides the song details in a human-readable format.
        /// It uses ROT13 to decode the encrypted song title.
        /// </summary>
        /// <returns>A formatted string showing the decrypted title, album, artist, and year</returns>
        public string Decrypt()
        {
            // Decrypts the encrypted title and combines it with other details to display song info
            return $"Title: {Rot13(Encrypt())} ({Year})\nAlbum: {Album}\nArtist: {Artist}";
        }

        /// <summary>
        /// Encrypt method that encodes the song title using the ROT13 algorithm.
        /// </summary>
        /// <returns>The ROT13-encrypted version of the song title</returns>
        public string Encrypt()
        {
            // Encrypts the title using ROT13 and returns the encoded string
            return Rot13(Title);
        }

        /// <summary>
        /// Helper method for ROT13 encryption/decryption.
        /// Since ROT13 is a symmetric encryption method, running it twice restores the original text.
        /// </summary>
        /// <param name="input">The string to be encrypted or decrypted</param>
        /// <returns>A string transformed by ROT13</returns>
        private string Rot13(string input)
        {
            // Convert the input to a character array to manipulate each character
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++) // Loop through each character in the array
            {
                char c = buffer[i]; // Current character

                if (c >= 'a' && c <= 'z') // If it's a lowercase letter
                {
                    // Rotate lowercase letters by 13 within alphabet bounds
                    buffer[i] = (char)('a' + (c - 'a' + 13) % 26);
                }
                else if (c >= 'A' && c <= 'Z') // If it's an uppercase letter
                {
                    // Rotate uppercase letters similarly
                    buffer[i] = (char)('A' + (c - 'A' + 13) % 26);
                }
            }
            // Return the resulting string after encryption/decryption
            return new string(buffer);
        }
    }
}
