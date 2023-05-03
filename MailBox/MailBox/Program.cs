using System;


namespace MailBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details of mail1:");
            string[] mail1=Console.ReadLine().Split(',');

            DateTime dt = Convert.ToDateTime(mail1[5]);

            Mail m1= new Mail(long.Parse(mail1[0]), mail1[1], mail1[2], mail1[3], mail1[4],dt,double.Parse(mail1[6]));
            Console.WriteLine(m1);
            Console.WriteLine("Enter details of mail2:");
            string[] mail2 = Console.ReadLine().Split(',');

            DateTime dt1 = Convert.ToDateTime(mail2[5]);

            Mail m2 = new Mail(long.Parse(mail2[0]), mail2[1], mail2[2], mail2[3], mail2[4], dt1, double.Parse(mail2[6]));
            Console.WriteLine(m2);

            if(m1.Equals(m2))
            {
                Console.WriteLine("Mail 1 and Mail 2 are same");
            }
            else
            {
                Console.WriteLine("Mail 1 and Mail 2 are different");
            }
        }
    }
}
