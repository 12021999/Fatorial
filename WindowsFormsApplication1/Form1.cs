using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

       static double FatorialIt(double number){
           if (number <= 1){
               return 1;
           }
           double result = 1;
           for (double i = 0; i < number; i++){
             result *= number - i;
           }
           return result;
        }

        static double FatorialRec(double number){
            if (number <= 1){
                return 1;
            }else return number * FatorialRec(number - 1);
        }

        private void buttonIt_Click(object sender, EventArgs e){
            txtBox.Text = Regex.Replace(txtBox.Text, "[^0-9]", "0");
            double input;
            input = Convert.ToDouble(txtBox.Text);
            labelResult.Text = Convert.ToString(FatorialIt(input));
        }

        private void buttonRec_Click(object sender, EventArgs e){
            txtBox.Text = Regex.Replace(txtBox.Text, "[^0-9]", "0");
            double input;
            input = Convert.ToDouble(txtBox.Text);
            labelResult.Text = Convert.ToString(FatorialRec(input));
        }



    }
}
