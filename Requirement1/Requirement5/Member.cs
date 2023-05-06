using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    public class Member
    {
        string firstname;
        string lastname;
        string emailid;

        public Member()
        {

        }

        public Member(string firstname, string lastname, string emailid)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailid = emailid;
        }

        public override string ToString()
        {
            return string.Format($"Member:{firstname},{lastname},{emailid}");
        }

        public void checking(string email)
        {
            if(email.Contains("0")&& ((email.EndsWith(".com"))||(email.EndsWith(".org"))))
            {
                Console.WriteLine("valid mail");
            }
            else
            {
                throw new InvalidEmailException(email);
            }
        }
    }
}
