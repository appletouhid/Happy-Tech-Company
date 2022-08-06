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
    public partial class REGISTRATION : Form
    {
        public REGISTRATION()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == textBox7.Text)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ID is required");
                    return;
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Name is required");
                    return;
                }

                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Address is required");
                    return;
                }


                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Phone number is required");
                    return;
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("Email id is required");
                    return;
                }
                else if (textBox6.Text == "")
                
                {
                    MessageBox.Show("password is required");
                    return;
                }
                else if (textBox7.Text == "")
                {
                    MessageBox.Show("password is required");
                    return;
                }

                SqlConnection con = new SqlConnection (DBHelper.dbString());
                String str = "  insert into [interviewee] (idNo,name,adress,phone,email,pass,cpass) values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                new DASHBOARD().Show();
                this.Hide();
            }
            else
            {

                label9.Hide();
                label9.Text = "Password mismatch   ";


            }
        }

        private void REGISTRATION_Load(object sender, EventArgs e)
        {

        }
    }
}
