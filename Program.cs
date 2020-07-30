using System;
using System.Collections;

namespace Lab4_6_Array_To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.6 To-Do List");

            string[] days = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
            string[] tasks = new string[7];

            //for (int i = 0; i < days.Length; i++) 
            //{
            //    Console.WriteLine(days[i]);

            //}

            Console.Write("\n Type in your Sunday task here: ");
            tasks[0] = Console.ReadLine();

            Console.Write(" Type in your Monday task here: ");
            tasks[1] = Console.ReadLine();

            Console.Write(" Type in your Tuesday task here: ");
            tasks[2] = Console.ReadLine();

            Console.Write(" Type in your Wednesday task here: ");
            tasks[3] = Console.ReadLine();

            Console.Write(" Type in your Thursday task here: ");
            tasks[4] = Console.ReadLine();

            Console.Write(" Type in your Friday task here: ");
            tasks[5] = Console.ReadLine();

            Console.Write(" Type in your Saturday task here: ");
            tasks[6] = Console.ReadLine();


            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine("\n Task for " + days[i] + ": "+ tasks[i]);
               // Console.WriteLine(tasks[i]);

            }



        }
    }
}
