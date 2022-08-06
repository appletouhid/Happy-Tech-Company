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
    public partial class FEEDBACK_FOR_INTERVIEWEE : Form
    {
        public FEEDBACK_FOR_INTERVIEWEE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBHelper.dbString());

            string query = "select email,category,comments from [feedback]";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new DASHBOARD().Show();
            this.Hide();
        }

        private void FEEDBACK_FOR_INTERVIEWEE_Load(object sender, EventArgs e)
        {

        }
    }
}
