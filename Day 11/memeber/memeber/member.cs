using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpooling
{
    internal class member
    {
        private long _id;

        public long Id
        {
            get { return Id; }
            set { Id = value; }
        }
        private string _firstname;

        public string Firstname

        {
            get { return Firstname; }
            set { Firstname = value; }

        }
        private string _lastname;

        public string Lastname

        {
            get { return Lastname; }

            set { Lastname = value; }
        }
        private string _email;

        public string Email
        {
            get
            {
                return Email;
            }
            set { Email = value; }
        }
        private string _contactnumber;

        public int ContactNumber
        {
            get { return ContactNumber; }
            set { ContactNumber = value; }
        }
        private string Licensenumber;

        public string LicenseNumber
        {
            get { return Licensenumber; }
            set { Licensenumber = value; }
        }

        private DateTime _licensestartdate;

        public int Licensestartdate
        {
            get { return Licensestartdate; }
            set { Licensestartdate = value; }
        }
        private DateTime _licenseexpirydate;


        public DateTime Licenseexpirydate

        {
            get { return Licenseexpirydate; }
            set { Licenseexpirydate = value; }
        }

        public object Contactnumber { get; private set; }

        public member() { }
        public member(long Id, string Firstname, string Lastname, string email, string contactnumber, string licensenumber, string licensestartdate, string licenseexpirydate)
        {
            Id = Id;
            Firstname = Firstname;
            Lastname = Lastname;
            Email = email;
            ContactNumber = ContactNumber;
            Licensenumber = licensenumber;
            Licensestartdate = Licensestartdate;
            Licenseexpirydate = Licenseexpirydate;

        }

        public override string ToString()

        {

            return string.Format($"Member:{_firstname},{_lastname}\n" + $"member contact details:{_contactnumber} , {_email}");

        }

        public override bool Equals(object obj)

        {

            member member = obj as member;

            if (Email.ToLower() == member.Email.ToLower() && Contactnumber.ToLower() == member.Contactnumber.ToLower())
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





