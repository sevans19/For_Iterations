using System;

namespace For_Iterations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // loops through a sequence of items and checks until you 
            // find a successful match

            // i = 0 -- introducing variable and initializing it 
            // i < 10 -- is it true that i is less than 10?
            // i++  -- increment operator 
            for (int i = 0; i < 10; i++)
            {
                // repeats this code until i is no longer less than 10
                //Console.WriteLine(i.ToString()); 


                //interrupts the flow of the for loop 
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }

            // type "for" and then hit tab twice 
            for (int i = 0; i < max; i++)
            {

            }


            Console.ReadLine();
        }
    }
}
