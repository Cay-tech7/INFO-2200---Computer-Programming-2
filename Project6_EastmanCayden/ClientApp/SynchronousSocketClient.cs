using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class SynchronousSocketClient
    {
        //Declare varibesl for server prot and Ip address
        private const int SERVER_PORT = 11000;
        private const string SERVER_ADDRESS = "127.0.0.1"; //LOCAL DEFAULT IP ADDRESS ON DEVICE

        // Sends a message to the server and returns the server's response
        public string ContactServer(string clientRequest)
        {
            string serverResponse;

            try
            {
                // create an object that will handle our TCP connections
                TcpClient client = new TcpClient();

                //ATTEMPT TO ESTABLISH A CONNECTION TO OUR SERVER USING THE PROVIDED PORT AND IP ADDRESS
                client.Connect(IPAddress.Parse(SERVER_ADDRESS), SERVER_PORT);

                //access the network stream of data between the server and the client
                NetworkStream clientServerStream = client.GetStream();

                //create a writer that can write/send to our server
                StreamWriter writer = new StreamWriter(clientServerStream);

                //create a reader that can read/receive from our server
                StreamReader reader = new StreamReader(clientServerStream);

                //enable sthe writer to send across small bits of data withough having to wait for larger chunks
                //send the client request acress, regardless of how big or small the request is
                writer.AutoFlush = true;

                //write/send teh client request to the server
                writer.WriteLine(clientRequest); 

                //grab the resplonse from the server
                serverResponse = reader.ReadLine();

                //close everything
                clientServerStream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                serverResponse = ex.Message;
            }

            return serverResponse;
        }
    }
}
