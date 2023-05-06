using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Member member1 = new Member();
            Console.WriteLine("Member 1:");
            Console.WriteLine("Id:");
            member1.Id=long.Parse(Console.ReadLine());
            Console.WriteLine("First name:");
            member1.FirstName=Console.ReadLine();
            Console.WriteLine("Last name:");
            member1.LastName=Console.ReadLine();
            Console.WriteLine("Email:");
            member1.Email=Console.ReadLine();
            Console.WriteLine("Contact Number:");
            member1.ContactNumber=Console.ReadLine();
            Console.WriteLine("License Number:");
            member1.LicenseNumber=Console.ReadLine();
            Console.WriteLine("License Start Date:");
            member1.LicenseStartDate=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("License Expiry Date:");
            member1.LicenseExpiryDate=DateTime.Parse(Console.ReadLine());

           Member member2 = new Member();
            Console.WriteLine("Member 2:");
            Console.WriteLine("Id:");
            member2.Id = long.Parse(Console.ReadLine());
            Console.WriteLine("Firstname:");
            member2.FirstName = Console.ReadLine();
            Console.WriteLine("Lastname:");
            member2.LastName = Console.ReadLine();
            Console.WriteLine("Email:");
            member2.Email = Console.ReadLine();
            Console.WriteLine("Contact Number:");
            member2.ContactNumber = Console.ReadLine();
            Console.WriteLine("License Number:");
            member2.LicenseNumber = Console.ReadLine();
            Console.WriteLine("License Start Date:");
            member2.LicenseStartDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("License Expiry Date:");
            member2.LicenseExpiryDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(member1.ToString());
            Console.WriteLine(member2.ToString());

            if (member1.Equals(member2))
            {
                Console.WriteLine("Member 1 is same as Member 2");
            }
            else
            {
                Console.WriteLine("Member 1 and Member 2 are different");
            }
        }
    }
}
