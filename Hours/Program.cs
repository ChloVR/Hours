using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours
{
    class Program
    {
        

        static void Main(string[] args)
        {
          Console.WriteLine("/////////// Hours ///////////");
          Calculatehours();



        }


        public static void Calculatehours()
        {
            float startTime;
            float endTime;
            float breakTime;
            float hours;
            float totalHours;
            string response;

            Console.WriteLine("Please Enter Start Time:");
            startTime = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(startTime);
            Console.WriteLine("Please Enter End Time:");
            endTime = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(endTime);
            Console.ReadLine();
            Console.WriteLine("Please enter Break Time in Hours.");
            breakTime = Convert.ToSingle(Console.ReadLine());
            hours = endTime - startTime;
            totalHours = hours - breakTime;

            Console.WriteLine("Your Hours for that day: " + totalHours + "hrs");
            Console.ReadLine();
            Console.WriteLine("Do you wish to calculate another day ? ");
            response = Convert.ToString(Console.ReadLine());
            if (response == "yes")
            {
                Calculatehours();
            }
           
        }
    }
}
