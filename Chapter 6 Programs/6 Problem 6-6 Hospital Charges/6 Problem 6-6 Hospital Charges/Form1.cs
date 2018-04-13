using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Problem_6_6_Hospital_Charges
{
    public partial class Form1 : Form
    {
        // Const variable for hospital cost per day
        private const double HOSPITAL_COST_PER_DAY = 350.00;
        // Variables that need to be access by more than one method
        private double hospitalStayCost;   // To hold variable for hospital stay cost
        private double miscCharges;        // To hold variable for total misc charges

        public Form1()
        {
            InitializeComponent();
        }

        // Calculate hospital stays cost:  routine will receive the number of days
        //   and return the total cost of the stay
        private double CalcStayCharges(int hospitalDays)
        {
            return (hospitalDays * HOSPITAL_COST_PER_DAY);
        }

        // Sum up the miscellaneous charges:  routine will receive the medication charges,
        //  surgery charges, lab fees, and physical rehabilation charges and will 
        //  return the total miscellaneous charges
        private double CalcMiscCharges(double med, double surgery, double lab, double phys)
        {
            return (med + surgery + lab + phys);
        }

        // Validate input for Days is valid for numeric calculations
        private bool DaysisValid(ref int hospitalDays)
        {
            bool daysIsValid = false;

            // try to convert input
            if (int.TryParse(tbDaysStay.Text, out hospitalDays))
            {
                daysIsValid = true;
            }
            return daysIsValid;
        }

        // Validate input for misc charges is valid for numeric calculations
        private bool MiscIsValid(ref double medCharges, ref double surgeryCharges,
            ref double labFees, ref double physRehabCharges)
        {
            bool miscIsValid = false;

            if (tbMedCharges.Text == "")
            {
                tbMedCharges.Text = "0";
            }

            if (tbSurgery.Text == "")
            {
                tbSurgery.Text = "0";
            }
            if (tbLabFees.Text == "")
            {
                tbLabFees.Text = "0";
            }
            if (tbPhysRehab.Text == "")
            {
                tbPhysRehab.Text = "0";
            }


            // try to convert inputs
            if (double.TryParse(tbMedCharges.Text, out medCharges))
            {
                if (double.TryParse(tbSurgery.Text, out surgeryCharges))
                {
                    if (double.TryParse(tbLabFees.Text, out labFees))
                    {
                        if (double.TryParse(tbPhysRehab.Text, out physRehabCharges))
                        {
                            miscIsValid = true;
                        }
                        else
                        {
                            // Display an error message for Physical Rehabitation
                            MessageBox.Show("Physical Rehabitation has to be Numeric");
                        }
                    }
                    else
                    {
                        // Display an error message for Lab Fees
                        MessageBox.Show("Lab Fees has to be Numeric");
                    }
                }
                else
                {
                    // Display an error message for Surgery Fees
                    MessageBox.Show("Surgery Fees has to be Numeric");
                }
            }
            else
            {
                // Display an error message for Medication Charges
                MessageBox.Show("Medication Charges has to be Numeric");
            }
            return miscIsValid;
        }
           
        private void btnHospitalStay_Click(object sender, EventArgs e)
        {
            int hospitalDays = 0;         // To hold variable for hospital days
            // double hospitalStayCost;  //  Declare global To hold variable for hospital stay cost

            if (DaysisValid(ref hospitalDays))
            {
                hospitalStayCost = CalcStayCharges(hospitalDays);
                lblOutDaysCost.Text = hospitalStayCost.ToString("n2");
            }

        }

        private void btnMiscCharges_Click(object sender, EventArgs e)
        {
            // double miscCharges;   // To hold variable for total misc charges
                                  // Total of medication, surgery, lab fees, and physical rehab
            // individual charges:
            double medCharges =0.0, surgeryCharges=0.0, labFees=0.0, physRehabCharges=0.0; 

            if (MiscIsValid(ref medCharges, ref surgeryCharges,ref labFees, ref  physRehabCharges))
            {
                miscCharges = CalcMiscCharges(medCharges, surgeryCharges, labFees, physRehabCharges);
                lblOutMiscCost.Text = miscCharges.ToString("n2");
            }
        }

        private void btnTotalCost_Click(object sender, EventArgs e)
        {
            double totalCost = 0.0;   // To hold the total cost of everything

            int hospitalDays = 0;         // To hold variable for hospital days
            // double hospitalStayCost;  // Defined Global To hold variable for hospital stay cost

            if (DaysisValid(ref hospitalDays))
            {
                hospitalStayCost = CalcStayCharges(hospitalDays);
                lblOutDaysCost.Text = hospitalStayCost.ToString("n2");
            }

            // double miscCharges;   // Defined Globally. To hold variable for total misc charges
                                     // Total of medication, surgery, lab fees, and physical rehab
                                     // individual charges:
            double medCharges = 0.0, surgeryCharges = 0.0, labFees = 0.0, physRehabCharges = 0.0;

            if (MiscIsValid(ref medCharges, ref surgeryCharges, ref labFees, ref physRehabCharges))
            {
                miscCharges = CalcMiscCharges(medCharges, surgeryCharges, labFees, physRehabCharges);
                lblOutMiscCost.Text = miscCharges.ToString("n2");
            }

            totalCost = hospitalStayCost + miscCharges;
            lblOutTotalCost.Text = totalCost.ToString("n2");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            tbDaysStay.Text = "";
            tbLabFees.Text = "";
            tbMedCharges.Text = "";
            tbPhysRehab.Text = "";
            tbSurgery.Text = "";

            // Clear the Output labels
            lblOutDaysCost.Text = "";
            lblOutMiscCost.Text = "";
            lblOutTotalCost.Text = "";


        }

    }
}
