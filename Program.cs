using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Student_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>() { "null", "Mark Haines", "James Moulton", "Andrew Klima", "Tommy Waalkes", "Maggie Tamanini", "Jerome Brown", "Trent Nedbal", "Troy Vizina", "Kevin Jackson II", "Joshua Carolin", "Sean Boatman", "Kate Datema", "Maronda Anderson-Johnson"};
            List<string> hometowns = new List<string>() { "null", "Grand Rapids", "Toledo", "Grayslake", "Raleigh", "Montrose", "Milwaukee", "Rochester", "Indian River", "Detroit", "Northville", "Eaton Rapids", "Zeeland", "Unknown"};
            List<string> favFood = new List<string>() { "null", "Cilantro", "Sushi", "Sushi", "Chicken Curry", "Movie Theatre Popcorn", "Italian Cuisine", "Tacos", "Broccoli", "Asian Cuisine", "Nalesniki", "Meat", "Pizza", "Unknown" };
            List<string> homeState = new List<string>() { "null", "Michigan", "Ohio", "Illinois", "North Carolina", "Michigan", "Wisconsin", "Michigan", "Michigan", "Michigan", "Michigan", "Michigan", "Michigan", "Unknown"};


            Console.WriteLine("Welcome to the May 2021 C# Class!");
            Console.WriteLine($"There are 13 members in the class. \n");

            bool again = true;
            while (again == true)
            {
                string input = GetStudentNumber($"Which class member would you like to learn about? (Enter a number 1-13)");

                int index = int.Parse(input);


                string name = studentNames[index];

                bool badEntry = true;
                while (badEntry == true)
                {
                    string input2 = GetUserInput($"Class member {input} is {name}.  What would you like to learn about them? HomeTown, HomeState, or FavoriteFood?");

                    if (input2 == "hometown")
                    {
                        string ht = hometowns[index];
                        Console.WriteLine(ht);
                        break;
                    }
                    else if (input2 == "favoritefood")
                    {
                        string ff = favFood[index];
                        Console.WriteLine(ff);
                        break;
                    }
                    else if (input2 == "homestate")
                    {
                        string hs = homeState[index];
                        Console.WriteLine(hs);
                        break;
                    }
                    else
                    {
                        string error = "That data does not exist.";

                        Console.WriteLine(error);
                    }
                }
                again = GetContinue();
            }

        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        public static string GetUserInputName(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower().Trim();
            return input;

        }
        public static string GetStudentNumber(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower().Trim();
            int input1 = int.Parse(input);
            if (input1 > 13)
            {
                return "That member does not exist.";

            }
            else
            {
                return input;
            }
        }

        public static bool GetContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to learn more? y/n");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine();
                Console.Write("Have a great day!");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand your response, please try again...");
                return GetContinue();
            }
        }
    }
}




