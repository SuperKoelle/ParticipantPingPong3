using System;
using System.Text.RegularExpressions;

namespace Kata
{
    public class Participant
    {
        private string name;
        private int telephoneNumber;
        private int zipCode;
        private string city;
        private string country;
        private string registreringsNumber;

        public string RegistrationNumber
        {
            get { return registreringsNumber; }
            set { registreringsNumber = value; }
        }


        public string Country
        {
            get { return country; }
            set { country = value; }
        }


        public string City
        {
            get { return city; }
            set { 
                    if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                    {
                    city = value; 
                    }
                    else
                    {
                        throw new ArgumentException("Vejle can only acce");
                    }
                }
        }


        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }


        public int TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }


        public string Name
        {
            get { return name; }
            set {

                if (!string.IsNullOrEmpty(value))
                {
                    if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                    {
                        name = value;
                    }
                    else
                    {
                        throw new ArgumentException("Name cannot be didgets or special characters");
                    }
                    
                }
                else
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

            }
        }

    }
}
