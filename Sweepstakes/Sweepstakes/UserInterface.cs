using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        public void GetFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name:");
            contestant.firstName = Console.ReadLine();
        }
        public void GetLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your Last name:");
            contestant.lastName = Console.ReadLine();
        }
        public void GetEmail(Contestant contestant)
        {
            Console.WriteLine("Please enter your E-mail address:");
            contestant.email = Console.ReadLine();
        }
        public void GetRegistration(Contestant contestant)
        {
            contestant.registrationNumber ++;

        }
    }
}
