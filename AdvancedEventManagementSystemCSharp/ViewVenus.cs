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
    public partial class ViewVenus : Form
    {
        public ViewVenus()
        {
            InitializeComponent();
        }

        private void ViewVenus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventVDataSet.venue' table. You can move, or remove it, as needed.
            this.venueTableAdapter.Fill(this.eventVDataSet.venue);
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM venue where id='"+textBox1.Text +"'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
