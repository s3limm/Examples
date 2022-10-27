using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class CreateRandomNumber : Form
    {
        public CreateRandomNumber()
        {
            InitializeComponent();
        }
        int buyuk , kucuk;
        private void btnWrite_Click(object sender, EventArgs e)
        {
            int[] number = new int[10];
            Random random = new Random();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(1, 100);
            }

            foreach (int numbers in number)
            {
                lstNumbers.Items.Add(numbers);

                if (numbers < kucuk)
                {
                    kucuk = numbers;
                }
                else if (numbers > buyuk)
                {
                    buyuk = numbers;
                }
            }

            MessageBox.Show($"en buyuk sayı : {buyuk} \n en kucuk sayı : {kucuk}");

        }
    }
}
