using System;

namespace ContactApp.Model
{
    [Serializable]
    class Contact : IComparable<Contact>
    {
        private string fname;
        private string lname;
        private string address;
        private long mobileNo;
        private string email;

        public Contact(string fname, string lname, string address, long mobileNo, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.mobileNo = mobileNo;
            this.email = email;
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public long MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string LName
        {
            get { return lname; }
            set { lname = value; }
        }

        public string FName
        {
            get { return fname; }
            set { fname = value; }
        }

        public int CompareTo(Contact contact)
        {
            if (contact == null) {
                return 1;
            }
            return this.FName.CompareTo(contact.FName);
        }
    }
}
