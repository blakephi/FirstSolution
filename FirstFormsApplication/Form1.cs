using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(getNum1.Text);
            num2 = Convert.ToInt32(getNum2.Text);
            String operation = Convert.ToString(getOperation.Text);
        }
        private void getNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void getOperation_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
