using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    class Customer
    {
        public string Firstname, Lastname, Email, Address;
        public int PhoneNumber, rentaldate;
        
        public string getFirstname()
        {
            return Firstname;
        }
        public void setFirstname(string Firstname)
        {
            this.Firstname = Firstname;
        }

        public string getLastname()
        {
            return Lastname;
        }
        public void setLastname(string Lastname)
        {
            this.Lastname = Lastname;
        }
        public string getEmail()
        {
            return Email;
        }
        public void setEmail(string Email)
        {
            this.Email = Email;
        }
        public string getAddress()
        {
            return Address;
        }
        public void setAddress(string Address)
        {
            this.Address = Address;
        }
        public int getPhoneNumber()
        {
            return PhoneNumber;
        }
        public void setPhoneNumber(int PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
        public int getrentaldate()
        {
            return rentaldate;
        }
        public void setrentalDate(int rentaldate)
        {
            this.rentaldate = rentaldate;
        }



    }
}
