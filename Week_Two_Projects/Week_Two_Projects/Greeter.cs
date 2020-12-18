using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_Two_Projects
{
    [TestClass]
    public class Greeter
    {
        public void SayingHello()
        {
            Console.WriteLine("What is uour name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hey, " + userName);
        }

        //need to have something that takes in a name
        // then says hello

        //need to also be able to say goodby to that name
        // after saying hello, needs to be a parameter in the method

        //need to figureout how to work with datetime
        //most likely an if statement

        //put this all together 
    }

}
