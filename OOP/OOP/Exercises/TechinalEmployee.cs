using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Exercises
{
    class TechinalEmployee : Employee
    {
        public int successfulCheckIns = 5;
        public TechinalEmployee(string name) : base(name, 75000)
        {

        }

        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
            // return base.employeeStatus();
        }
    }
}
