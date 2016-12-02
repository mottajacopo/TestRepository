using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace es_07
{
    public class Person
    {
        //campi
        private string firstName;
        private string lastName;
        private string emailAddress;
        private DateTime dateOfBirth;

        //proprietà
        public string FirstName
        {
            get
            {
                return this.firstName;
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
                return this.lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }
            set
            {
                string formatCorrect = @"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})";
                if (Regex.Matches(value, formatCorrect).Count > 0)
                    emailAddress = value;
                else
                    throw new ApplicationException();

            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                if ((dateOfBirth < DateTime.Now) || ((DateTime.Now.Year - dateOfBirth.Year) < 120))
                {
                    dateOfBirth = value; //se non è una data futura o un valore > 120 OK
                }
                throw new ApplicationException(); //altrimenti genero un'eccezione
            }
        }

        //costruttori
        public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.dateOfBirth =  dateOfBirth;
            if((dateOfBirth > DateTime.Now) || ((DateTime.Now.Year - dateOfBirth.Year) > 120))
            {
                throw new ApplicationException();
            }
        }
        
        public Person(string firstName, string lastName, string emailAddress)
            : this(firstName, lastName, emailAddress, DateTime.Today)
        {
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
            : this(firstName, lastName, null, dateOfBirth)
        {
        }
        
        public bool Adult
        {
            get
            {
                if((DateTime.Now.Year - dateOfBirth.Year) > 18)
                {
                    return true;
                }
                return false;
            }
        }
        public string SunSign
        {
            get
            {
                string []sunSign = {"Acquario", "Pesci", "Ariete", "Toro", "Gemelli", "Cancro", "Leone", "Vergine", "Bilancia", "Scorpione", "Sagittario", "Capricorno"};
                int[] signStartDay = { 21, 20, 21, 21, 21, 22, 23, 24, 23, 23, 23, 22 };
                string currentSign = "Capricorno";

                for(int i = 0; i < 12; i++)
                {
                    DateTime dateSign = new DateTime(dateOfBirth.Year, i + 1, signStartDay[i]);
                    if (dateOfBirth > dateSign)
                    {
                        currentSign = sunSign[i]; 
                    }
                }
                return currentSign;
            }
        }
        public string ChineseSign
        {
            get
            {
                string[] chineseSign = { "Topo", "Bue", "Tigre", "Coniglio", "Drago", "Serpente", "Cavallo", "Capra", "Scimmia", "Gallo", "Cane", "Maiale" };
                int[] chineseSignYear = { 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031 };

                string currentSign = null;
                for(int i = 0; i < 12; i++)
                {
                    if ((((chineseSignYear[i] - dateOfBirth.Year) % 12) == 0)) {
                        currentSign = chineseSign[i];
                    }
                }
                return currentSign;
            }
        }
        public bool Birthday
        {
            get
            {
                if((DateTime.Today.Day == dateOfBirth.Day) && DateTime.Today.Month == DateOfBirth.Month)
                {
                    return true;
                }
                return false;
            }
        }
        public string ScreenName
        {
            get
            {
                StringBuilder screenName = new StringBuilder();
                string firstNameLowCase = firstName.ToLower();
                screenName.Append(firstNameLowCase);
                string lastNameLowCase = lastName.ToLower();
                screenName.Append(lastNameLowCase);
                screenName.Append(DateOfBirth.Year);

                return screenName.ToString();
            }
        }
    }
}
