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
    public partial class CollectToNumbers : Form
    {
        public CollectToNumbers()
        {
            InitializeComponent();
        }
        int toplam = 0;
        int i = 0;
        private void btnCollect_Click(object sender, EventArgs e)
        {
            string numbers = txtNumbers.Text;
            int number = Convert.ToInt32(numbers);

            do
            {
                toplam = toplam + i;
                i++;

                if (number == i)
                {
                    lblResult.Text = toplam.ToString();
                }
            }
            while (number > i);

        }
    }
}
