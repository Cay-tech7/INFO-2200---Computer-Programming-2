using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ServerApp
{
    /// <summary>
    /// Handles server-side logic for requests and responses
    /// </summary>
    public class SynchronousSocketListener
    {
        // File paths
        private static readonly string BASE_DIR = AppDomain.CurrentDomain.BaseDirectory;
        readonly string FACT_FILE_PATH = Path.Combine(BASE_DIR, "UVUFacts.txt");
        readonly string COURSE_FILE_PATH = Path.Combine(BASE_DIR, "UVUCourses.txt");
        readonly string SERVER_LOG_PATH = Path.Combine(BASE_DIR, "serverLog.txt");

        // Connection details
        const int SERVER_PORT = 11000;
        const string SERVER_ADDRESS = "127.0.0.1";

        // Random number generator for selecting facts or courses
        Random randomGenerator = new Random();

        // Listener object for incoming TCP connections
        TcpListener listener;

        // Arrays to hold loaded data
        string[] facts;
        string[] courses;

        /// <summary>
        /// Different levels of alerts for logging.
        /// INFO - general info, WARNING - invalid requests, ERROR - critical issues
        /// </summary>
        public enum AlertLevel { INFO, WARNING, ERROR }

        /// <summary>
        /// Server constructor — loads data files on startup
        /// </summary>
        public SynchronousSocketListener()
        {
            LoadFiles();
        }

        /// <summary>
        /// Reads facts and courses from their respective text files
        /// </summary>
        public void LoadFiles()
        {
            try
            {
                facts = File.ReadAllLines(FACT_FILE_PATH);
                courses = File.ReadAllLines(COURSE_FILE_PATH);
                Log(AlertLevel.INFO, "Text files imported successfully");
            }
            catch (Exception ex)
            {
                Log(AlertLevel.ERROR, ex.Message);
            }
        }

        /// <summary>
        /// Opens the connection and listens for incoming TCP requests
        /// </summary>
        public void StartListening()
        {
            listener = new TcpListener(IPAddress.Parse(SERVER_ADDRESS), SERVER_PORT);
            listener.Start();

            //Logs the location of the server log file for easy access
            Console.WriteLine($"Log file location: {Path.GetFullPath(SERVER_LOG_PATH)}");

            Log(AlertLevel.INFO, $"Server started listening on {SERVER_ADDRESS}:{SERVER_PORT}");
            ProcessSocket();
        }

        /// <summary>
        /// Continuously processes incoming client requests over a socket connection
        /// </summary>
        public void ProcessSocket()
        {
            while (true)
            {
                try
                {
                    Socket serverSocket = listener.AcceptSocket();

                    NetworkStream stream = new NetworkStream(serverSocket);
                    StreamReader reader = new StreamReader(stream);
                    StreamWriter writer = new StreamWriter(stream);
                    writer.AutoFlush = true;

                    string clientRequest = reader.ReadLine();
                    Log(AlertLevel.INFO, $"Received from client: {clientRequest}");

                    // Validate the client request and respond accordingly
                    if (string.IsNullOrWhiteSpace(clientRequest)) continue;

                    // Check if the request is for a fact or a course and respond with a random entry from the respective array
                    if (clientRequest.ToUpper() == "FACT" && facts != null)
                    {
                        string randomJoke = $"Fact: {facts[randomGenerator.Next(facts.Length)]}";
                        Log(AlertLevel.INFO, $"Sending to client: {randomJoke}");
                        writer.WriteLine(randomJoke);
                    }

                    // Check if the request is for a course and respond with a random entry from the courses array
                    else if (clientRequest.ToUpper() == "COURSE" && courses != null) // ← fixed casing
                    {
                        string randomConspiracy = $"Course: {courses[randomGenerator.Next(courses.Length)]}";
                        Log(AlertLevel.INFO, $"Sending to client: {randomConspiracy}");
                        writer.WriteLine(randomConspiracy);
                    }

                    // If the request is not recognized, log a warning and inform the client
                    else
                    {
                        Log(AlertLevel.WARNING, $"Invalid request from client: {clientRequest}");
                        writer.WriteLine($"Could not process request: {clientRequest}");
                    }
                }

                // If any exceptions occur during processing, log the error details
                catch (Exception ex)
                {
                    Log(AlertLevel.ERROR, ex.ToString());
                }
            }
        }

        /// <summary>
        /// Records a log entry to the server log file and the console
        /// </summary>
        public void Log(Enum alertLevel, string logEntry)
        {
            string line = $"{DateTime.Now}\t{alertLevel}\t{logEntry}";
            Console.WriteLine(line);
            File.AppendAllText(SERVER_LOG_PATH, line + "\n");
        }
    }
}