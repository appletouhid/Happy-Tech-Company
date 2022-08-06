using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PROFILE().Show();
            this.Hide();
        }

        private void DASHBOARD_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TEMPLATE().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new INTERVIEWER_FEEDBACK().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new FEEDBACK_FOR_INTERVIEWEE().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new HOMEPAGE().Show();
            this.Hide();
        }
    }
}
