using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _RJA3_WeekOneChallenges
{
    class Program
    {
        static void Main(string[] args)
        { //challenge 1
            string firstName = "Richard";
            string lastName = "Anderson III";
            int age = 24;

            Console.WriteLine($"{firstName} {lastName} is {age} years old.");
            //challenge 2
            string[] favoriteBooks = { "Lord of the Rings", "The Hero With A Thousand Faces", "The 4-Hour Workweek", "Lean Startup" };

           //challenge 3
            var list = new List<DateTime>();
            list.Add(DateTime.Now);
            list.Add(new DateTime(2001, 1, 1));
            list.Add(new DateTime(2006, 4, 20));
            list.Add(new DateTime(2121, 4, 29));
            list.Add(new DateTime(1002, 4, 5));

            //challenge 4
            int add = age + 7;
            int subtract = age - 7;
            double divide = age / 7;
            int mult = age * 7;
            int mod = age % 7;

            Console.WriteLine($"{add}" +
                $"{subtract}" +
                $"{divide}" +
                $"{mult}" +
                $"{mod}");



            //challenge 5

            Console.WriteLine("How many hours did you sleep last night?");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }

            else if (userInput >= 8 && userInput < 10)
            {
                Console.WriteLine("You feel well rested.");
            }
            else if (userInput >= 4 && userInput < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("That is alot or no hours! Either way, find help!");
            }

            //challenge 6
           
            bool dayFeel = true;
            while (dayFeel == true)
            {
                Console.WriteLine("How was your day?" +
                    "1. Great" +
                    "2. Good" +
                    "3. Okay" +
                    "4. Bad");
                string response = Console.ReadLine().ToUpper();
                switch (response)
                {
                    case "1":
                    case "Great":
                        Console.WriteLine("That's great!");
                        break;
                    case "2":
                    case "Good":
                        Console.WriteLine("Sounds like a passive answer.");
                        break;
                    case "3":
                    case "Okay":
                        Console.WriteLine("What's wrong?");
                        break;
                    case "4":
                    case "Bad":
                        Console.WriteLine("I'll show you a bad day.");
                        break;
                    default:
                        Console.WriteLine("Answer the question, bub.");
                        break;
                }
       
            }
        }
    }
}
