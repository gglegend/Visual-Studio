using System;

namespace Phonebook
{
    class Person
    {
        public string name;
        public long phonenumber;
        public override string ToString()
        {
            return ("My name is " + name + ". My phone number is " + phonenumber);
            
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Person friend1 = new Person();
            friend1.name = "Jack";
            friend1.phonenumber = 7189054350;

            Person friend2 = new Person();
            friend2.name = "Theodore";
            friend2.phonenumber = 7187569825;

            Person friend3 = new Person();
            friend3.name = "Michael";
            friend3.phonenumber = 9176789946;

            Person friend4 = new Person();
            friend4.name = "Joshua";
            friend4.phonenumber = 3476581549;

            Person [] friends = { friend1, friend2, friend3, friend4 };

            for (int i = 0; i < 4; i++)
                Console.WriteLine(friends[i]);

            

            /* string[] names = { "Jack", "Theodore", "Michael", "Joshua" };

            long[] phonenumbers = { 7189054350, 718756982, 9176789946, 3476581549};

            

            for (int i = 0; i<4; i++)
            {
                Console.WriteLine(names[i]);
                Console.WriteLine(phonenumbers[i]);
            } */
              
        }
    }
}
