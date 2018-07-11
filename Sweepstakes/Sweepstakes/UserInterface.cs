using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string managerSelection;

        public static void GetFirstName(Contestant contestant)
        {
            Console.WriteLine("\n\nContestant Info:\n\nPlease enter your first name:");
            contestant.firstName = Console.ReadLine();
        }
        public static void GetLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your last name:");
            contestant.lastName = Console.ReadLine();
        }
        public static void GetEmail(Contestant contestant)
        {
            Console.WriteLine("Please enter your E-mail address:");
            contestant.email = Console.ReadLine();
        }
        public static void GetRegistration(Contestant contestant)
        {
            contestant.registrationNumber++;

        }
        public static void GetSweepstakesManager()
        {
            Console.WriteLine("Which data structure would you like to use? Please enter stack or queue:");
            managerSelection = Console.ReadLine();
        }
    }

}
