using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HappyTech
{
    public partial class INTERVIEWER_FEEDBACK : Form
    {
        public INTERVIEWER_FEEDBACK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ID is required");
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("EMAIL is required");
                return;
            }

            else if (richTextBox1.Text == "")
            {
                MessageBox.Show("COMMENT is required");
                return;
            }

            SqlConnection con = new SqlConnection(DBHelper.dbString());
            string str = "  insert into [userfeedback] (idn,adminemail,comments) values('" + textBox1.Text + "','" + textBox2.Text + "', '" + richTextBox1.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();

            label4.Show();
            label4.Text = "SEND FEED BACK FROM INTERVEWEE SUCCESSFULLY";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new DASHBOARD().Show();
            this.Hide();
        }

        private void INTERVIEWER_FEEDBACK_Load(object sender, EventArgs e)
        {

        }
    }
}
