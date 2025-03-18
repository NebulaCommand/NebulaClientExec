using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NezurAPI;

namespace ClientExecutor
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NezurAPI.API.Inject();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            NezurAPI.API.Execute(fastColoredTextBox1.Text);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.BringToFront();
            guna2Panel3.SendToBack();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SendToBack();
            guna2Panel3.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
