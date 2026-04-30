//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 
//Participation or Assignment #: MO1 Assignment 1 The College Search Form and Console App

//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
//unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
//was directly created by Generative AI, unless explicitly stated in the assignment instructions,
//nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
//unless specifically provided in the assignment, constitutes cheating,
//and that I will receive a zero on this project if I am found in violation of this policy.

using System.Threading.Channels;

namespace Project1_EastmanCayden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cayden's College City Look Up App!");
            Console.WriteLine();

            //grab user input
            Console.WriteLine("Please enter a college and i will return the city (x to exit): ");
            string userInput = Console.ReadLine();

            //create a dictionary to hold our colleges and cities
            Dictionary<string, string> collegeCityDictionary = new Dictionary<string, string>();

            //open the file
            StreamReader reader = new StreamReader("C:\\Users\\cayde\\Documents\\UVU Spring 2026\\IFNO 2200 - Computer Programming 2\\colleges.txt");

            while (reader.EndOfStream != true)
            {
                //create a variable to hold the current line value
                string currentLine = reader.ReadLine();

                //split each line in the file into a college and city, then add them to our dictionary
                string[] currentCollegeCityPair = currentLine.Split(',');

                string currentCollege = currentCollegeCityPair[0];
                string currentCity = currentCollegeCityPair[1];

                // add the college and city to our dictionary
                collegeCityDictionary.Add(currentCollege, currentCity);
            }

            //close the reader
            reader.Close();

            //loop through the user's input until they exit
            while (userInput != "x")
            {
                //checks if the user's input exists in our dictionary
                if (collegeCityDictionary.TryGetValue(userInput, out string matchedCity))
                {
                    Console.WriteLine();
                    Console.WriteLine($"College : {userInput}");
                    Console.WriteLine($"City : {matchedCity}");
                }
                // handles random logic
                else if (userInput == "random")
                {
                    //Create a random number generator
                    Random randomGenerator = new Random();

                    //grab a random index from the dictionary
                    int randomCollegeIndex = randomGenerator.Next(collegeCityDictionary.Count);

                    //using the random index, grab the associated key value
                    string randomCollege = collegeCityDictionary.ElementAt(randomCollegeIndex).Key;

                    // check if the random college exists in our dictionary
                    if (collegeCityDictionary.TryGetValue(randomCollege, out string randomCity))
                        Console.WriteLine();
                    Console.WriteLine($"College: {randomCollege}");
                    Console.WriteLine($"City: {randomCity}");
                }
                //handle erors
                else
                {
                    //invalid input
                    Console.WriteLine($"Could not find {userInput} in the text file! Please try again.");
                    Console.WriteLine();
                }
                //promt the user for another input
                Console.WriteLine("Please enter a college and I will return a city! (x to exit)");
                userInput = Console.ReadLine();
            }           
        }
    }
}
