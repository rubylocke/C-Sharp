using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Problem_2_Car_Class
{
    public partial class CarClass : Form
    {
        private Car car = new Car();
        const int ACCELERATE = 5;

        public CarClass()
        {
            InitializeComponent();
        }
       
        // GetCarData accepts a Car object as an argument
        // It assigns the data entered by the user to the object's properties
        private void GetCarData(Car enterCar)
        {
             // get the car year
            car.Year = tbYear.Text;

            // get the car make
            car.Make = tbMake.Text;
         }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            // Create a Car object
            Car enterCar = new Car();

            // Get the car data
            GetCarData(enterCar);
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            car.Accelerate(ACCELERATE);
            tbSpeed.Text = car.Speed.ToString("n1");
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            car.Brake(ACCELERATE);
            tbSpeed.Text = car.Speed.ToString("n1");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
