using System;

namespace train
{
    class Program
    {

        static double mileage = 0;
        static double distancefromhome = 0;
        static double verticalDist = 0;
        static double horizontalDist = 0;

        static void Move(string direction, int distance)
        {

            mileage = mileage + distance;

            if (direction == "north")
            { 
              //  distancefromhome = distancefromhome + distance;
                verticalDist = verticalDist + distance;
            }

            else if (direction == "south")
            {
                
               // distancefromhome = distancefromhome - distance;
                verticalDist = verticalDist - distance;
            }

            else if (direction == "east")
            {
                
               // distancefromhome = distancefromhome + distance;
                horizontalDist = horizontalDist + distance;
            }

            else if (direction == "west")
            {
                
               // distancefromhome = distancefromhome - distance;
                horizontalDist = horizontalDist - distance;
            }

            else
                Console.WriteLine("could not compute");


            distancefromhome = Math.Sqrt(verticalDist * verticalDist + horizontalDist * horizontalDist);


        }

    /*    public static void Swing()
        {
            for (int i = 0; i<11;i++)
            Console.WriteLine("swinging");
        } */

        static void Main(string[] args)
        {

            Move("north", 9);
            Move("south", 32);
            Move("east", 76);
            Move("west", 24);

            Console.WriteLine(mileage);
            Console.WriteLine(verticalDist);
            Console.WriteLine(horizontalDist);
            Console.WriteLine("The distance from home is " + distancefromhome);

            

        }
    }
}
