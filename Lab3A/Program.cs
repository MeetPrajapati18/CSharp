using System;
using System.Collections.Generic;
using System.IO;

namespace Lab3A
{
    /// <summary>
    /// This class handles the functionality of managing and displaying a media collection consisting of books, songs, and movies.
    /// </summary>
    internal class Program
    {
        // Lists to store media items
        static List<string> books = new List<string>(); // declaring books varible to store all books in this
        static List<string> songs = new List<string>(); // declaring songs varible to store all songs in this
        static List<string> movies = new List<string>(); // declaring movies varible to store all movies in this

        /// <summary>
        /// Main entry point of the application. It'll display the menu and keep asking user to choose and will keep asking to user untill user choose to exit.
        /// it keep asking to user untill user wants to exit the application
        /// </summary>
        static void Main(string[] args)
        {
            // ReadData will read all data from the file and 
            ReadData();

            // Variable to control the loop for the menu
            bool continueProgram = true;

            // Main loop for the menu options
            while (continueProgram)
            {
                // Clear the console screen and display the menu
                Console.Clear();
                Console.WriteLine("Nick's Media Collection");
                Console.WriteLine("=======================");
                Console.WriteLine("1. List All Books");
                Console.WriteLine("2. List All Movies");
                Console.WriteLine("3. List All Songs");
                Console.WriteLine("4. List All Media");
                Console.WriteLine("5. Search All Media by Title");
                Console.WriteLine("6. Exit Program");

                // Get the user's choice
                string choice = Console.ReadLine();

                // Handle user choice using a switch statement
                switch (choice)
                {
                    case "1":
                        ListAllBooks(); // Call method to list all books
                        break;
                    case "2":
                        ListAllMovies(); // Call method to list all movies
                        break;
                    case "3":
                        ListAllSongs(); // Call method to list all songs
                        break;
                    case "4":
                        ListAllMedia(); // Call method to list all media (books, songs, movies)
                        break;
                    case "5":
                        SearchMediaByTitle(); // Call method to search media by title
                        break;
                    case "6":
                        continueProgram = false; // Exit the program
                        break;
                    default:
                        // Handle invalid choices
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        /// <summary>
        /// Reads data from the "Data.txt" file and populates the lists for books, songs, and movies.
        /// </summary>
        public static void ReadData()
        {
            try
            {
                string filename = "Data.txt"; // Hardcoded file name

                // Read all content from the file and split by "-----" to separate each entry
                string[] allObjects = File.ReadAllText(filename).Split(new string[] { "-----" }, StringSplitOptions.RemoveEmptyEntries);

                // Loop through each media entry
                foreach (string entry in allObjects)
                {
                    // Split each entry by newlines and then by the delimiter '|'
                    string[] mediaData = entry.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] details = mediaData[0].Split('|');

                    // Validate the data format
                    if (details.Length < 4)
                    {
                        Console.WriteLine("Invalid data format.");
                        continue; // Skip invalid entries
                    }

                    // Determine the media type and process accordingly
                    if (details[0] == "BOOK")
                    {
                        // Parse book data and add it to the books list
                        string title = details[1];
                        int year = int.Parse(details[2]);
                        string author = details[3];
                        books.Add($"Book Title: {title} ({year})\nAuthor: {author}\n--------------------");
                    }
                    else if (details[0] == "SONG")
                    {
                        // Parse song data and add it to the songs list
                        string title = details[1];
                        int year = int.Parse(details[2]);
                        string artist = details[3];
                        string album = details[4];
                        songs.Add($"Song Title: {title} ({year})\nArtist: {artist}, Album: {album}\n--------------------");
                    }
                    else if (details[0] == "MOVIE")
                    {
                        // Parse movie data and add it to the movies list
                        string title = details[1];
                        int year = int.Parse(details[2]);
                        string director = details[3];
                        movies.Add($"Movie Title: {title} ({year})\nDirector: {director}\n--------------------");
                    }
                }
            }
            catch (Exception e)
            {
                // Handle any file reading errors
                Console.WriteLine($"An error occurred while reading the file: {e.Message}");
            }
        }

        /// <summary>
        /// Displays a list of all books in the collection.
        /// </summary>
        public static void ListAllBooks()
        {
            Console.WriteLine("\nList of Books:");
            foreach (var book in books)
            {
                // Print each book's details
                Console.WriteLine(book);
            }
            // Wait for the user to press any key before returning to the menu
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        /// <summary>
        /// Displays a list of all movies in the collection.
        /// </summary>
        public static void ListAllMovies()
        {
            Console.WriteLine("\nList of Movies:");
            foreach (var movie in movies)
            {
                // Print each movie's details
                Console.WriteLine(movie);
            }
            // Wait for the user to press any key before returning to the menu
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        /// <summary>
        /// Displays a list of all songs in the collection.
        /// </summary>
        public static void ListAllSongs()
        {
            Console.WriteLine("\nList of Songs:");
            foreach (var song in songs)
            {
                // Print each song's details
                Console.WriteLine(song);
            }
            // Wait for the user to press any key before returning to the menu
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        /// <summary>
        /// Displays a list of all media (books, songs, and movies) in the collection.
        /// </summary>
        public static void ListAllMedia()
        {
            Console.WriteLine("\nList of All Media:");
            // Print books, songs, and movies
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
            // Wait for the user to press any key before returning to the menu
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        /// <summary>
        /// Allows the user to search all media by title.
        /// </summary>
        public static void SearchMediaByTitle()
        {
            // Ask the user to enter a search term
            Console.Write("Enter a title to search for: ");
            string searchTerm = Console.ReadLine().ToLower(); // Make search case-insensitive

            // Create a list to store matching results
            List<string> results = new List<string>();

            // Search through books, songs, and movies for the search term
            foreach (var book in books)
            {
                if (book.ToLower().Contains(searchTerm)) // Case-insensitive search
                {
                    results.Add(book); // Add matching book to results
                }
            }
            foreach (var song in songs)
            {
                if (song.ToLower().Contains(searchTerm)) // Case-insensitive search
                {
                    results.Add(song); // Add matching song to results
                }
            }
            foreach (var movie in movies)
            {
                if (movie.ToLower().Contains(searchTerm)) // Case-insensitive search
                {
                    results.Add(movie); // Add matching movie to results
                }
            }

            // Display the search results or a message if no matches are found
            if (results.Count == 0)
            {
                Console.WriteLine("No results found.");
            }
            else
            {
                Console.WriteLine("\nSearch Results:");
                foreach (var result in results)
                {
                    // Print each matching result
                    Console.WriteLine(result);
                }
            }

            // Wait for the user to press any key before returning to the menu
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }
}
