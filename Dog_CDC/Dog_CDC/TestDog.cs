using System;
using System.Collections.Generic;
using System.Text;

namespace Dog_CDC
{
    public class TestDog
    {
        public static void Main(String[] args)
        {
            Dog firstDog = new Dog();

            Console.WriteLine("What is the first dogs age?");
            firstDog.setAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("What is the first dogs name?");
            firstDog.setName(Console.ReadLine());
            //set info for Dogs

            Console.WriteLine(firstDog.toString());
            Console.WriteLine(firstDog.getName() + "'s age in dog years is " + firstDog.calcDogYears());
        }
       
    }
}
