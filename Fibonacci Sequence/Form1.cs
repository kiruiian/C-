using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci_Sequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int n) && n >= 0)
            {
                string result = GenerateFibonacci(n);
                lblResult.Text = result;
            }
            else
            {
                lblResult.Text = "Please Enter a real integer!";
            }
        }
        private string GenerateFibonacci(int n)
        {
            if (n == 0) return "0";
            if (n == 1) return "1";
            int a = 0, b = 1, next;
            string sequence = "0,1";

            for (int i = 2; i <= n; i++)
            {
                next = a + b;
                sequence += "," + next;
                a = b;
                b = next;
            }
            return sequence;
        }
    }
}
