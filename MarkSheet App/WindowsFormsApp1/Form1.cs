using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            double Bio, SsT, Accounts, total, avg;
            string grade;

            Bio = int.Parse(txtBiology.Text);
            SsT = int.Parse(txtSST.Text);
            Accounts = int.Parse(txtAccounts.Text);

            total = Bio + SsT + Accounts;

            txtTotal.Text = total.ToString();

            avg = total / 3;

            txtAvg.Text = avg.ToString();


            //////////
            /// conditional statements

            if(avg >= 75)
            {
                grade = "A";
            }
            else if (avg >= 65)
            {
                grade = "B";
            }
            else if (avg >= 55)
            {
                grade = "C";
            }
            else if (avg >= 45)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }


            txtGrade.Text = grade;

        }
    }
}
