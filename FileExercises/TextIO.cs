using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExercises
{
    internal class TextIO
    {

        public void Run()
        {
            string path = @"text.txt";
            // Write file
            if (!File.Exists(path))
            {
                try
                {
                    // this make the new path
                    StreamWriter writer = new StreamWriter(path);
                    // what it writes
                    writer.WriteLine("Hello");
                    writer.WriteLine("And");
                    writer.WriteLine("Welcome!");
                    writer.Close();
                    // Dispose of the object
                    try
                    {
                        writer.Dispose();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            // Read file
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string str;
                    while ((str = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
