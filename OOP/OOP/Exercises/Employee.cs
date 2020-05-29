using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Exercises
{
    abstract class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        private static int employeeCount = 1;

        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }

            set
            {
                employeeBaseSalary = value;
            }
        }

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.employeeId = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        public string getName()
        {
            return this.Name;
        }

        public int getEmployeeId()
        {
            return this.employeeId;
        }

        public string toString()
        {
            return this.employeeId + " " + this.Name;
        }

        public abstract string employeeStatus();        
    }
}
