using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace MailReq2
{
    public class Mail
    {
        private long _id;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _to;

        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        private string _from;

        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        private DateTime _receivedDate;

        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { DateTime _receivedDate = value; }
        }
        private double _size;

        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Mail()
        {

        }
        public Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size)
        {
            Id = _id;
            To = _to;
            From = _from;
            Subject = _subject;
            Content = _content;
            ReceivedDate = _receivedDate;
            Size = _size;
        }

        //public override string ToString()
        //{
        //    return $"\nId: {Id} \nTo:{To} \nFrom: {From} \nSubject:{Subject}\nContent:{Content}\nReceived Date:{ReceivedDate.ToString("dd-mm-yyyy")}\nSize:{String.Format("{0:F1}", Size)}";
        //}

        public override string ToString()
        {
            return string.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15:dd-MM-yyyy} {6,15:F1}", Id, From, To, Subject, Content, ReceivedDate, Size);
        }
        public static Mail CreateMail(string detail)
        {

            string[] details = detail.Split(',');
            long id = long.Parse(details[0]);
            DateTime receivedDate = DateTime.Parse(details[5]);
            double size = double.Parse(details[6]);
            Mail md = new Mail(id, details[1], details[2], details[3], details[4], receivedDate, size);
            return md;
        }
    }
    public class MailFolder
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private List<Mail> _mailList;
        public List<Mail> MailList
        {
            get { return _mailList; }
            set { _mailList = value; }
        }
        public MailFolder()
        { }
        public MailFolder(string _name, List<Mail> _mailList)
        {
            this._name = _name;
            this._mailList = _mailList;
        }
        public void AddMailToFolder(Mail mail)
        {
            MailList.Add(mail);
        }
        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (var Item in _mailList)
            {
                if (Item.Id == id)
                {
                    MailList.Remove(Item);
                    count++;
                    break;
                }
                if (count == 1)
                {
                    //Console.WriteLine("Mail successfully deleted.");
                    return true;

                }
            }
           // Console.WriteLine("Mail not found in the folder");
            return false;

        }
        public void DisplayMails()
        {
            if (MailList.Count == 0)
            {
                Console.WriteLine("No mails to show");
            }
            else 
            {
                foreach (var Item in _mailList)
                {
                    Console.WriteLine("{0}", Name);
                    Console.WriteLine(Item.ToString());
                }
            }
            
        }
    }

}

