using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Requirement1
{
    public class Member
    {
		private long _id;

		public long Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}
		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}
		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}
		private string _contactNumber;

		public string ContactNumber
		{
			get { return _contactNumber; }
			set { _contactNumber = value; }
		}
		private string _licenseNumber;

		public string LicenseNumber
		{
			get { return _licenseNumber; }
			set { _licenseNumber = value; }
		}
		private DateTime _licenseStartDate;

		public DateTime LicenseStartDate
		{
			get { return _licenseStartDate; }
			set { _licenseStartDate = value; }
		}
		private DateTime _licenseExpiryDate;

		public DateTime LicenseExpiryDate
		{
			get { return _licenseExpiryDate; }
			set { _licenseExpiryDate = value; }
		}

		public Member()
		{

		}

		public Member(long id,string firstname,string lastname,string email,string contactnumber,string licensenumber,DateTime licensestartdate,DateTime licenseexpirydate)
		{
			_id = id;
			_firstName = firstname;
			_lastName=lastname;
			_email = email;
			_contactNumber = contactnumber;
			_licenseNumber = licensenumber;
			_licenseStartDate = licensestartdate;
			_licenseExpiryDate = licenseexpirydate;
		}

        public override string ToString()
        {
			return String.Format($"Member:{_firstName},{_lastName}\nMember contact details:{_contactNumber},{_email}");
        }

        public override bool Equals(object obj)
        {
            Member temp = obj as Member;
            if (temp.Email.ToLower() == Email.ToLower() && temp.ContactNumber.ToLower() == ContactNumber.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }





    }
}
