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
    public partial class ADMIN_DASHBOARD : Form
    {
        public ADMIN_DASHBOARD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ADMIN_PROFILE_CHECK().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ADMIN_TEMPLATE_CHECK().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ADMIN_FEEDBACK_CHECK().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new ADMIN().Show();
            this.Hide();
        }

        private void ADMIN_DASHBOARD_Load(object sender, EventArgs e)
        {

        }
    }
}
