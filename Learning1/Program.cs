namespace Learning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //variable declarations
            int i = 0;
            float f = 0.1f;
            double d = 0.1;
            bool b = true;
            char c = 'A';
            string s = "Sample String";

            //concatination
            Console.WriteLine("Hello, World! " + i);

            //functions
       
      


            Console.WriteLine(i);
            Console.ReadKey();
        }

        void TestFunction(){
            Console.WriteLine("This is a test function.");
        }
        bool SecondTestFunction(int i){
            return i < 100;
        }
    }
}
