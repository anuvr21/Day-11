using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MailReq2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Mail> ls = new List<Mail>();
            Console.WriteLine("Enter the name of the folder:");
            string fname = Console.ReadLine();
            MailFolder mf = new MailFolder(fname,ls);
            Mail ml=new Mail();           
            while (true)
            {
                    Console.WriteLine("1. Add Mail");
                    Console.WriteLine("2. Delete Mail");
                    Console.WriteLine("3. Display Mails");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice");
                    int ch = int.Parse(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                        Console.WriteLine("Enter the details in csv format");
                        string details= Console.ReadLine();
                        ml=Mail.CreateMail(details);
                        mf.AddMailToFolder(ml);
                        Console.WriteLine("Mail successfully added");
                            break;
                    case 2:
                        Console.WriteLine("Enter the id to be deleted");
                        long id=long.Parse(Console.ReadLine());
                        mf.RemoveMailFromFolder(id);
                        Console.WriteLine("Mail successfully deleted");
                        break;
                    case 3:
                        mf.DisplayMails();
                        break;
                    case 4:
                        break;
                }
            }
        }
    }   
}
