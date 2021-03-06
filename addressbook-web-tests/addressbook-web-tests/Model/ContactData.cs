﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstName;
        private string lastName;


        public ContactData(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            return firstName == other.firstName && lastName == other.lastName; 
        }


        public override int GetHashCode()
        {

            return FirstName.GetHashCode() & LastName.GetHashCode();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other.LastName, null))
            {
                if (Object.ReferenceEquals(other.FirstName, null))
                {
                    return 1;
                }
            }

            return FirstName.CompareTo(other.FirstName) & LastName.CompareTo(other.LastName);
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

    }
}
