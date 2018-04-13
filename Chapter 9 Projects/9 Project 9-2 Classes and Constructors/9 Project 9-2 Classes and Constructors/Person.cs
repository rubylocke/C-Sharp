using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Project_9_2_Classes_and_Constructors
{
    class Person
    {
        // Encapsulating class variables (Hiding and protecting the variables)
        // Class fields are hidden because they have private access modifier
        // We can access these fields using get/set methods or properties
        // In the next program you will learn how to use get/set properties
        private string newName;
        private double newHeight;
        private double newWeight;

        // type ctor word, then press tab button twice to generate contructor
        // A constructor is a method that have a class name
        // A constructor does not return a value
        // Default constructor is used to se class variables to default values
        // Default constructor has no parameters
        // Default value for string is null
        // Default value for int is 0, double is 0.0
        public Person()
        {

        }

        // Overloaded constructor with 3 parameters
        public Person(string Name, double Height, double Weight)
        {
            newName = Name;
            newHeight = Height;
            newWeight = Weight;
        }

        // Creating Accessors and Mutators (Getters and Setters methods)
        // get method always return value
        // get method must return class field
        public string getName()
        {
            return newName;
        }

        public double getHeight()
        {
            return newHeight;
        }

        public double getWeight()
        {
            return newWeight;
        }

        // set method is of type void
        // in this case, it has one parameter
        // The parameter receives an argument value to set the corresponding class field
        public void setName(string name)
        {
            newName = name;
        }

        public void setHeight(double height)
        {
            newHeight = height;
        }

        public void setWeight(double weight)
        {
            newWeight = weight;
        }
    }
}
