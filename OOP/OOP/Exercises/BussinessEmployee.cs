using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Exercises
{
    class BussinessEmployee : Employee
    {
        public double bonusBudget = 1000;
        public BussinessEmployee(string name) : base(name, 5000)
        {

        }

        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
            // return base.employeeStatus();
        }
    }
}
