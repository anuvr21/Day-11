using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBoxReq2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
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
            this.Id = _id;
            To = _to;
            From = _from;
            Subject = _subject;
            Content = _content;
            ReceivedDate = _receivedDate;
            Size = _size;
        }
        
        public override string ToString()
        {
            return $"\nId: {Id} \nTo:{To} \nFrom: {From} \nSubject:{Subject}\nContent:{Content}\nReceived Date:{ReceivedDate.ToString("dd-mm-yyyy")}\nSize:{String.Format("{0:F1}", Size)}";
        }
        public static Mail CreateMail(string detail)
        {

            string[] details=detail.Split(',');
            DateTime receivedDate = DateTime.Parse(details[5]);
            double size = double.Parse(details[6]);
            Mail mailObj = new Mail();
            return mailObj;
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
    }
}
