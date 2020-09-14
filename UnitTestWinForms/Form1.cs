using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestWinForms
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtOne.Text = rnd.Next(100).ToString();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtTwo.Text = rnd.Next(3000).ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtThree.Text = rnd.Next(30000,100000).ToString();
        }
    }
}
