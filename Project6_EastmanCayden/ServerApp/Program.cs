using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cayden's UVU Facts/Courses!");
            Console.WriteLine("=============================================");

            //create a listener handle incomeing client requests
            SynchronousSocketListener listener = new SynchronousSocketListener();
            listener.StartListening();
        }
    }
}
