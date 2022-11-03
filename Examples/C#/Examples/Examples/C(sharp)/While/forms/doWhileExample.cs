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
    public partial class doWhileExample : Form
    {
        public doWhileExample()
        {
            InitializeComponent();
        }
        int i = 0;
        private void btnWrite_Click(object sender, EventArgs e)
        {
        do
            {
                lstNumbers.Items.Add(i);
                i++;
            }
        while (i<11);
            
        }
    }
}
