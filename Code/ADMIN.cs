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
    public partial class ADMIN : Form
    {
        public ADMIN()
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
                MessageBox.Show("password is required");
                return;
            }

            SqlConnection con = new SqlConnection(DBHelper.dbString());
            con.Open();
            string str1 = "select IDNO,pass from [admin] where IDNO='" + textBox1.Text + "' and pass='" + textBox2.Text + "'";

            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataAdapter da = new SqlDataAdapter(str1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                textBox1.Hide();
                textBox2.Hide();
                label1.Hide();
                label2.Hide();
                button1.Hide();
                //button2.Hide();
                //label5.Show();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    new ADMIN_DASHBOARD().Show();
                    this.Hide();
                    //label5.Text = "hi" + dr["name"].ToString() + "thank you for using this app";
                }

            }
            else
            {
               
                
                label5.Show();
                label5.Text = "Id or Password is wrong...!";
            }

        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new HOMEPAGE().Show();
            this.Hide();
        }
    }
}
