using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Problem_2_Car_Class
{
    class Car
    {
        // fields to represent Car class
        private string _year;       // The car year
        private string _make;       // The car make
        private int _speed;         // the car current speed rating

        // Constructor
        public Car()
        {
            _year = "";
            _make = "";
            _speed = 0;
        }

        // Override constructor for year and make only
        public Car(string y, string m)
        {
            _year = y;
            _make = m;
            _speed = 0;
        }
        
        // Override constructor
        public Car(string y, string m, int s)
        {
            _year = y;
            _make = m;
            _speed = s;
        }

        // get year
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // get make
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        // get speed
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public void Accelerate(int s)
        {
            _speed += s;
        }

        public void Brake(int s)
        {
            _speed -= s;
        }

        public void ShowSpeed()
        {
            MessageBox.Show("The " + _year +
                             " " + _make +
                             " is going " + _speed);
        }
    }
}
