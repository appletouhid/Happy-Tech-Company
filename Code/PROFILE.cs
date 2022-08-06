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
    public partial class PROFILE : Form
    {
        public PROFILE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(DBHelper.dbString());

            string query = "select *from [interviewee] ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new UPDATE_PROFILE().Show();
            //this.Hide();

            SqlConnection con = new SqlConnection(DBHelper.dbString());

            string query = "  insert into [interviewee] (idno,name,adress,phone,email) values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["idNo"].Value.ToString();
                textBox2.Text = row.Cells["name"].Value.ToString();
                textBox3.Text = row.Cells["adress"].Value.ToString();
                textBox4.Text = row.Cells["phone"].Value.ToString();
                textBox5.Text = row.Cells["email"].Value.ToString();



            }






        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(DBHelper.dbString());

            string query = "delete from [interviewee] where idNo='" + textBox1.Text + "'and email = '" + textBox5.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close(); 



        }

        private void PROFILE_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new DASHBOARD().Show();
            this.Hide();
        }
    }
}
