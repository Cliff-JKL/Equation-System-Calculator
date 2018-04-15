using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        static Equations inpEq = new Equations();
        static Calculator calc = new Calculator(3, inpEq);

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string addS = xFactorTextBox.Text + xLabel.Text + yFactorTextBox.Text + yLabel.Text + zFactorTextBox.Text + zLabel.Text + cFactorTextBox.Text + zeroLabel.Text;

            eqListView.Items.Add(new ListViewItem(addS));
        }
    }
}
