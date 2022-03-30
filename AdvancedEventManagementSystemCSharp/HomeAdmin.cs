using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedEventManagementSystemCSharp
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void addVenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVenue obj = new AddVenue();
            obj.ShowDialog();
        }

        private void bookingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingHistory obj2 = new BookingHistory();
            obj2.ShowDialog();
        }

        private void bookingStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingStatus obj3 = new BookingStatus();
            obj3.ShowDialog();
        }

        private void viewFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFeedback obj1 = new AdvancedEventManagementSystemCSharp.ViewFeedback();
            obj1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj4 = new Form1();
            obj4.ShowDialog();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
