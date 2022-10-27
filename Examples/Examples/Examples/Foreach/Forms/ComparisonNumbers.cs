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
    public partial class ComparisonNumbers : Form
    {
        public ComparisonNumbers()
        {
            InitializeComponent();
        }

        int[] notes = {50 , 100 , 55 , 45 , 98 };

        private void NoteComparison_Load(object sender, EventArgs e)
        {
            foreach (int notlar in notes)
            {
                if(notlar > 50)
                {
                    MessageBox.Show($"Tebrikler notunuz {notlar} 50'den yüksek.");
                }
                else
                {
                    MessageBox.Show($"Maalesef kaldınız notunuz : {notlar}");
                }
            }
        }
    }
}
