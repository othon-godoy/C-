using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // sealed class Employee
    abstract class Employee
    {
        // private member variables
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        // public properties
        public string EmpNumber
        {
            get
            {
                return empNumber;
            }

            set
            {
                empNumber = value;
            }
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

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        // public methods
        public virtual void Login()
        {

        }

        public virtual void LogOff()
        {

        }

        public abstract void EatLunch();
    }
}
