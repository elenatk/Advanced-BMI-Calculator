using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(txtHeight.Text);
                double weight = double.Parse(txtWeight.Text);
                //calculate BMI
                double bmi = ((weight*703)/(height*height));

                //check BMI
                //under 18.5 - underweight; between 18.5-25 - optimal; over 25 - overweight
                if (bmi < 18.5)
                    lblResult.Text = "You're underweight " + "and your BMI is " + Math.Round(bmi);
                if (bmi > 25)
                    lblResult.Text = "You're overweight " + "and your BMI is " + Math.Round(bmi);
                if (bmi >= 18.5 || bmi <= 25)
                    lblResult.Text = "You weight is optimal " + "and your BMI is " + Math.Round(bmi);

                //displaying result
                //lblResult.Text = "Your BMI is " + bmi;
            }
            
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

