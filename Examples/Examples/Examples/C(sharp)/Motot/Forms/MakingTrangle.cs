using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class MakingTrangle : Form
    {
        public MakingTrangle()
        {
            InitializeComponent();
        }


        public void Triangle(int border1, int border2, int border3)
        {
            if (border1 == border2 && border1 == border3 && border2 == border3) 
            {
                lblResult.Text = "Üçgen eşkenardır";
            }
            else if (border1 != border2 && border1 != border3 && border2 != border3)
            {
                lblResult.Text = "Üçgen çeşitkenardır";
            }
            else
            {
                lblResult.Text = "Üçgen ikizkenardır.";
            }


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string number1 = txtBorder1.Text;
            string number2 = txtBorder2.Text;
            string number3 = txtBorder3.Text;

            int b1 = Convert.ToInt32(number1);
            int b2 = Convert.ToInt32(number2);
            int b3 = Convert.ToInt32(number3);

            Triangle(b1, b2, b3);
        }
    }
}
