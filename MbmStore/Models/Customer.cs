using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        //fields
        private List<string> phoneNumbers;
        DateTime birthDate;

        //properties
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public List<string> PhoneNumbers { get { return phoneNumbers; } }
        public List<Invoice> Invoices { get; set; }
        public DateTime Birthdate
        {
            set
            {
                birthDate = value;
                if (Age >= 120 || Age < 0)
                {
                    throw new Exception("Age is not valid");
                }

            }

            get { return birthDate; }
        }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now; int age;
                age = now.Year - birthDate.Year;
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                    age--;
                return age;

            }
        }


        //constructors
        public Customer(string firstname, string lastname, string address, string zip, string city, DateTime birthdate)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Address = address;
            this.Zip = zip;
            this.City = city;
            this.Birthdate = birthdate;
            this.phoneNumbers = new List<string>();
        }

        //methods

        public void AddPhoneNumber(string phone)
        {
            phoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
    }
}