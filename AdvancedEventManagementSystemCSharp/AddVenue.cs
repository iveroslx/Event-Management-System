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

namespace AdvancedEventManagementSystemCSharp
{
    public partial class AddVenue : Form
    {
        public AddVenue()
        {
            InitializeComponent();
        }

        private void AddVenue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventVDataSet5.venue' table. You can move, or remove it, as needed.
            this.venueTableAdapter.Fill(this.eventVDataSet5.venue);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM venue";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True");
            con.Open();
            string str1 = "select max(id) from venue;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True");
            con.Open();
            string gen = string.Empty;

            try
            {
                string str = "INSERT INTO venue(name,addr,phone,capacity,prefered,money) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(Id) from venue;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Venue Details Information Successfully..");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    comboBox1.Text = "--Select--";                   
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True"))
                    {
                        string str2 = "SELECT * FROM venue";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True");
            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select name,addr,phone,capacity,prefered,money from venue where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                                                
                        textBox2.Text = dr.GetValue(0).ToString();
                        textBox3.Text = dr.GetValue(1).ToString();
                        textBox4.Text = dr.GetValue(2).ToString();
                        textBox5.Text = dr.GetValue(3).ToString();
                        comboBox1.Text = dr.GetValue(4).ToString();
                        textBox6.Text = dr.GetValue(5).ToString();

                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + textBox1.Text + " Venues Details Record is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True");
            con.Open();
            try
            {
                string str = " Update venue set name='" + textBox2.Text + "',addr='" + textBox3.Text + "',phone='" + textBox4.Text + "',capacity='" + textBox5.Text + "',prefered='" + comboBox1.Text + "',money='" + textBox6.Text + "' where id='" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from venue;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("" + textBox2.Text + "The table's details have been updated successfully.. ", "Important Message");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    comboBox1.Text = "--Select--";
                    
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True"))
                    {
                        string str2 = "SELECT * FROM venue";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
