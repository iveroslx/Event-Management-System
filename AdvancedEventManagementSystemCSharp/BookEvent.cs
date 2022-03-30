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
    public partial class BookEvent : Form
    {
        public BookEvent()
        {
            InitializeComponent();
        }

        private void BookEvent_Load(object sender, EventArgs e)
        {
           
            this.book_eventTableAdapter.Fill(this.eventVDataSet4.book_event);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM book_event";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf.mdf;Integrated Security=True");
            con.Open();
            string str1 = "select max(id) from book_event;";

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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilenameC:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True");
            con.Open();
            string gen = string.Empty;

            try
            {
                string str = "INSERT INTO book_event(e_type,place,no_guest,date,equip,f_type,food,total) VALUES('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+comboBox2.Text +"','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox5.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(Id) from book_event;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Inserted Booking Event Details Information Successfully..");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    comboBox3.Text = "--Select--";
                    comboBox4.Text = "--Select--";
                    comboBox1.Text = "--Select--";
                    comboBox2.Text = "--Select--";
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True"))
                    {
                        string str2 = "SELECT * FROM book_event";
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

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
