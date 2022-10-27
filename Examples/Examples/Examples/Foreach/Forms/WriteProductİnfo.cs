using Examples.Examples.Foreach.Class;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Class> classes = new List<Class>
        {
        new Class() {productName = "Phone" , category = "Electronic" , price = 5000},
        new Class() {productName = "Television" , category = "Electronic" , price = 7000},
        new Class() {productName = "Chair" , category = "Fornuture" , price = 2000},
        };

        private void btnWrite_Click(object sender, EventArgs e)
        {
            foreach (Class item in classes)
            {
                lstProduct.Items.Add(item.productName);
                lstProduct.Items.Add(item.category);
                lstProduct.Items.Add(item.price);
            }
        }
    }
}
