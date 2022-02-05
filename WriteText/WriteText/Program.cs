using System;
using System.IO;

namespace WriteText
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\burro\\Desktop\\poem.txt";
            string poem = "\r\n\tl never saw a man who looked";
            poem += "\r\n\tWith such a wistful eye";
            poem += "\r\n\tUpon that little tent of blue";
            poem += "\r\n\tWhich prisoners call the sky";

            if (File.Exists(path))
            {
                Console.WriteLine("File Already Exists: " + path);

            }
            else
            {
                try
                {
                    File.WriteAllText(path, poem);
                    Console.WriteLine("File Written: " + path);
                }
                catch ( Exception error)
                {
                    Console.WriteLine(error.Message);
                }

            }
            Console.ReadKey();
        }
    }
}
