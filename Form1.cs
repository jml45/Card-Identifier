using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier
{
    public partial class frmCardIdentifier : Form
    {
        public frmCardIdentifier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CardLabelOutput.Text = "7 of Diamonds";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CardLabelOutput.Text = "10 of Spades";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CardLabelOutput.Text = "4 of Clubs";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CardLabelOutput.Text = "Ace of Hearts";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CardLabelOutput.Text = "Queen of Clubs";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CardLabelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
