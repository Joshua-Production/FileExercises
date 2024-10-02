using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.Text.Json;

/*
 * Write a Serialize and DeSerialize function for Contact struct.
 * Serialize should write the contents of the object into a file.
 * DeSeralize should read the contents of a file and assign them to the object's variables.
 */

namespace FileExercises
{
    
    // making the struct
    struct Contact
    {
        public string name;
        public string email;
        public int id;


        public Contact(string name, string email, int id)
        {
            this.name = name;
            this.email = email;
            this.id = id;

        }
        // making serialize function
        public void Serialize(string path)
        {
            try
            {
                // this make the new path
                StreamWriter writer = new StreamWriter(path);
                // what it writes
                writer.WriteLine(name + "  ");
                writer.WriteLine(email + "  ");
                writer.WriteLine(id + " ");
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
        //making Deserialize function
        public void DeSerialize(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {

                    


                    


                    name = reader.ReadLine();
                    email = reader.ReadLine();
                    
                    // we dont talk about id 
                    
                    



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        //making print function
        public void Print()

        {
            Console.WriteLine(name + " | " + email + " | " + id);
        }
    }
    internal class SerializeIO
    {
        public void Run()
        {


            // Make 3 contacts 
            Contact bob = new Contact("Bob", "bob@email.com", 1234);
            Contact fred = new Contact("Fred", "fred@email.com", 2345);
            Contact jane = new Contact("Jane", "Jane@email.com", 3456);

            // Write each contact to a file

            bob.Serialize(@"bob.txt");
            fred.Serialize(@"fred.txt");
            jane.Serialize(@"jane.txt");

            // Clear out contacts
            bob = new Contact();
            fred = new Contact();
            jane = new Contact();

            // Load contacts from file
            bob.DeSerialize(@"bob.txt");
            fred.DeSerialize(@"fred.txt");
            jane.DeSerialize(@"jane.txt");

            // Print contacts
            bob.Print();
            fred.Print();
            jane.Print();


        }




    }
}
