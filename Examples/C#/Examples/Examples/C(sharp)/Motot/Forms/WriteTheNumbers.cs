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
    public partial class WriteTheNumbers : Form
    {
        public WriteTheNumbers()
        {
            InitializeComponent();
        }
        
        public int Numbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if(i % 2 == 0)
                {
                    lstNumbers.Items.Add(i);
                }
            }
            return number;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            lstNumbers.Items.Clear();
            string number = txtNumbers.Text;
            int n1 = Convert.ToInt32(number);
            Numbers(n1);
        }
    }
}
