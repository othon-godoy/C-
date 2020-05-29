using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class DrinksMachine
    {
        // Methods, fields, properties and events go here

        // private member variables
        private int age;
        private string make;


        // public properties
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        // auto-implemented property
        public string Model { get; set; }

        // Constructors
        public DrinksMachine()
        {
            Age = 0;
        }
        public DrinksMachine(int age)
        {
            Age = age;
        }
        public DrinksMachine(string make, string model)
        {
            Make = make;
            Model = model;
        }
        public DrinksMachine(int age, string make, string model)
        {
            Age = age;
            Make = make;
            Model = model;
        }

        // The following statements define methods
        public void MakeCappuccino()
        {
            // Method logic goes here
        }

        public void MakeEspresso()
        {
            // Method logic goes here
        }

        // The following statement defines an event. The delegate difinition is not shown
        // public event OutOfBeansHandler OutOfBeans;
    }
}
