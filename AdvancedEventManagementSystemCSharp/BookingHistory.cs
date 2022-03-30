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
    public partial class BookingHistory : Form
    {
        public BookingHistory()
        {
            InitializeComponent();
        }

        private void BookingHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventVDataSet3.book_event' table. You can move, or remove it, as needed.
            this.book_eventTableAdapter.Fill(this.eventVDataSet3.book_event);
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
}
