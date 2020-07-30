using System;
using System.Collections;

namespace Lab4_6_Array_To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.6 To-Do List");

            // Define arrays to hold days of week and tasks
            string[] days = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
            string[] tasks = new string[7];

           
            // Capture user input into tasks array 
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

            // print date and task to console
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine("\n Task for " + days[i] + ": "+ tasks[i]);
               // Console.WriteLine(tasks[i]);

            }



        }
    }
}
