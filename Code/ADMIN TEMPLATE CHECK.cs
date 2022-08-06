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
    public partial class ADMIN_TEMPLATE_CHECK : Form
    {
        public ADMIN_TEMPLATE_CHECK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBHelper.dbString());

            string query = "select idNo,name,adress,phone,email from [interviewee]";
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
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["idNo"].Value.ToString();
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(DBHelper.dbString());

            string query = "select idno,image,objective,degree,institute,passyr,faculty,cgpa from [template]";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBHelper.dbString());

            string query = "select *from [skills] ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBHelper.dbString());

            string query = "select *from [projects] ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
        }

        private void ADMIN_TEMPLATE_CHECK_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new ADMIN_DASHBOARD().Show();
            this.Hide();
        }
    }
}
