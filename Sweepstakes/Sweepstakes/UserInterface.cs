using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void GetFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name:");
            contestant.firstName = Console.ReadLine();
        }
        public static void GetLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your Last name:");
            contestant.lastName = Console.ReadLine();
        }
        public static void GetEmail(Contestant contestant)
        {
            Console.WriteLine("Please enter your E-mail address:");
            contestant.email = Console.ReadLine();
        }
        public static void GetRegistration(Contestant contestant)
        {
            contestant.registrationNumber ++;

        }
    }
}
