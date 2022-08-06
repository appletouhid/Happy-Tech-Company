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
using System.Data.Sql;


namespace HappyTech
{
    public partial class ADMIN_FEEDBACK_CHECK : Form
    {
       
        public ADMIN_FEEDBACK_CHECK()
        {
            InitializeComponent();
        }
        
       
       
        string category;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            category = "Electrical";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("EMAIL is required");
                return;
            }
            else if (richTextBox1.Text == "")
            {
                MessageBox.Show("COMMENT is required");
                return;
            }
            else if (radioButton1.Checked)

                category = "Electrical";


            else if (radioButton2.Checked)

                category = "IT";


            else if (radioButton3.Checked)

                category = "Business";

            SqlConnection con = new SqlConnection(DBHelper.dbString());
            String str = " insert into [feedback] (email,category,comments) values('" + textBox1.Text + "','" + category + "', '" + richTextBox1.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();


            label5.Show();
            label5.Text = "SEND FEEDBACK SUCCESSFULLY";



            /*else if (radioButton1.Checked)

                category = "Electrical";


            else if (radioButton2.Checked)

                category = "IT";


            else if (radioButton3.Checked)

                category = "Business";*/

            //con.Open();
            // SqlCommand cmd = con.CreateCommand();
            // cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "insert into feedback('" + category + "'";
            // cmd.ExecuteNonQuery();
            // con.Close();





        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            category = "IT";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            category = "Business";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBHelper.dbString());

            string query = "select idNo,email from [interviewee]";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new ADMIN().Show();
            this.Hide();
        }

        private void ADMIN_FEEDBACK_CHECK_Load(object sender, EventArgs e)
        {

        }
    }
}
