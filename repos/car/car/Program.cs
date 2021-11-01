using System;

namespace car
{

    class Program
    {
        class Car
        {
            string model;
            string color;
            int speed;
            string photo;

            static int mileage = 0;
            static int distancefromhome = 0;

            void Drive(string direction, int distance)
            {
                Console.WriteLine(model + " is driving to the " + direction + " for " + distance + " miles");
            //    Console.WriteLine("It is " + color + " and it can go up to " + speed + " miles per hour");
                // Console.WriteLine("Here is a picture " + photo);

                mileage = mileage + distance;

                if (direction == "north")
                {
                    distancefromhome = distancefromhome;
                }

                else if (direction == "south")
                {
                    distancefromhome = distancefromhome;
                }

                else if (direction == "east")
                {
                 
                    distancefromhome = distancefromhome - distance;
                }

                else if (direction == "west")
                {
                    
                    distancefromhome = distancefromhome + distance;
                }

                else
                    Console.WriteLine("could not compute");
            }

            

            public static void Main(string[] args)
            {

                Car bug = new Car();
                bug.model = "Mustang";
                bug.color = "green";
                bug.speed = 40;
               
                bug.Drive("east", 45);
                bug.Drive("west", 36);
                bug.Drive("north", 76);
                bug.Drive("west", 7);
                bug.Drive("east", 31);

                Console.WriteLine(mileage);
                Console.WriteLine(distancefromhome);


            }


        }

    }
}
