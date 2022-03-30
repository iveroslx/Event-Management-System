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
    public partial class ViewFeedback : Form
    {
        public ViewFeedback()
        {
            InitializeComponent();
        }

        private void ViewFeedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventVDataSet1.feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.eventVDataSet1.feedback);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H110\Desktop\AdvancedEventManagementSystemCSharp\AdvancedEventManagementSystemCSharp\EventV.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM feedback";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
