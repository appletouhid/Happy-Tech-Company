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
using System.IO; 

namespace HappyTech
{
    public partial class TEMPLATE : Form
    {
        public TEMPLATE()
        {
            InitializeComponent();
        }

        private void TEMPLATE_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (textBox6.Text == textBox7.Text)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ID is required");
                    return;
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Objective is required");
                    return;
                }

                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Degree is required");
                    return;
                }


                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Institute is required");
                    return;
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("Pass year id is required");
                    return;
                }
                else if (textBox6.Text == "")

                {
                    MessageBox.Show("Faculty is required");
                    return;
                }
                else if (textBox7.Text == "")
                {
                    MessageBox.Show("CGPA is required");
                    return;
                }



                SqlConnection con = new SqlConnection(DBHelper.dbString());
                String str = " insert into [template] (idno,objective,degree,institute,passyr,faculty,cgpa) values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();


                
                byte[] iamges = null;
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                iamges = brs.ReadBytes ((int) streem.Length);

               // con.Open();
                string sqlQuery = "  insert into [template] (idno,objective,degree,institute,passyr,faculty,cgpa,image) values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "',@images)";
               // string sqlQuery = "  insert into [template] (image) values(@images)";
                cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.Add(new SqlParameter("@images", iamges));
                int N = cmd.ExecuteNonQuery();
                con.Close();


                label17.Show();
                label17.Text = "PHOTO INSERT SUCCESSFULLY AND TEMPLATE CREATED ...!";



            }
        
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(DBHelper.dbString());
        string imgLocation = "";
        SqlCommand cmd;
            
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            {
                if (textBox11.Text == "")
                {
                    MessageBox.Show("ID is required");
                    return;
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show("SKILLS is required");
                    return;
                }
                else if (richTextBox1.Text == "")
                {
                    MessageBox.Show("PLATFORM is required");
                    return;
                }

                SqlConnection con = new SqlConnection(DBHelper.dbString());
                String str = "  insert into [skills] (idnoo,skills,platform) values('" + textBox11.Text + "','" + textBox8.Text + "', '" + richTextBox1.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                
              

                 label9.Show();
                 label9.Text = " ADDED SUCCESSFULLY ";


                
            }




        }

        private void button6_Click(object sender, EventArgs e)
        {

            {
                if (textBox12.Text == "")
                {
                    MessageBox.Show("ID is required");
                    return;
                }
                else if (textBox9.Text == "")
                {
                    MessageBox.Show("PROJECT NAME is required");
                    return;
                }
                else if (textBox10.Text == "")
                {
                    MessageBox.Show("PLATFORM is required");
                    return;
                }

                else if (richTextBox2.Text == "")
                {
                    MessageBox.Show("DESCRIPTION is required");
                    return;
                }

                SqlConnection con = new SqlConnection(DBHelper.dbString());
                String str = "  insert into [projects] (idno,ProjectName,platform,description) values('" + textBox12.Text + "', '" + textBox9.Text + "','" + textBox10.Text + "','" + richTextBox2.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();


                label20.Show();
                label20.Text = "Added Projects successfully    ";



            }






        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new DASHBOARD().Show();
            this.Hide();
        }
    }
    }

