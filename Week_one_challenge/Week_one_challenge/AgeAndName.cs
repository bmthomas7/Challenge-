using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_one_challenge
{
    [TestClass]
    public class AgeAndName
    {
        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Ben";
            string lastName = "Thomas";
            int age = 23;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);


        }
        [TestMethod]

        public void Array()
        {
            string[] movie = { "Avatar", "Abominable", "Moana", "whitechristmas" };
            
        }
        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Now;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020 , 11 , 13));
            listOfDates.Add(new DateTime(2020, 11, 25));
            listOfDates.Add(new DateTime(2020, 11, 17));
            listOfDates.Add(new DateTime(2020, 11, 17));


        }

        [TestMethod]
        public void HowMuchSleepDidYouGet()
        {
            Console.WriteLine("How many hours of sleep did you get");
            int hours = 4;
            if (hours >= 10)
            {
                Console.WriteLine("Wow, that's a lot of sleep");
            }
            else if (hours > 8 && hours < 10)  //this could be done without the && because the if is everything above the 10
            {
                Console.WriteLine("That is a good amount of sleep!");
            }
            else if (hours > 4 && hours <= 8)
            {
                Console.WriteLine("That is below average of sleep");
            }
            else
            {
                Console.WriteLine("Go to bed!!");
            }
        }

    }

}
