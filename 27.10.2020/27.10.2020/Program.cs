
using System;

namespace _27._10._2020
{
    class Program
    {
       
        //task1
        class person
        {
            public string name { get; set; }

            public string surname { get; set; }
        }

        static void Main(string[] args)       
        {
            person fullname = new person();

            Console.WriteLine("Enter name:");
            fullname.name = Console.ReadLine();

            Console.WriteLine("Enter surname");
            fullname.surname = Console.ReadLine();

            string personInfo = fullname.surname + " " + fullname.name;
            Console.WriteLine(personInfo);

            //____________________________________________
            //task2
            //____________________________________________


            int number;

            Console.WriteLine("Eded daxil edin: ");
            number = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= 10; i++)
            { 
                Console.WriteLine(number + "*" + i + "=" + number * i); 
            
            }

            //_______________________________________________
            //task3
            //_______________________________________________

            Console.WriteLine("eded daxil edin: ");
            
            
            int eded;
            eded = Convert.ToInt32(Console.ReadLine());
            


            
        }
    }
}
