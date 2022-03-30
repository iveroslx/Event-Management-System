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
    public partial class HomeCust : Form
    {
        public HomeCust()
        {
            InitializeComponent();
        }

        private void bookEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookEvent obj = new BookEvent();
            obj.ShowDialog();
        }

        private void bookingStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingStatus obj1 = new AdvancedEventManagementSystemCSharp.BookingStatus();
            obj1.ShowDialog();
        }

        private void giveFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback obj2 = new AdvancedEventManagementSystemCSharp.Feedback();
            obj2.ShowDialog();
        }

        private void viewVenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewVenus obj3 = new AdvancedEventManagementSystemCSharp.ViewVenus();
            obj3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj4 = new AdvancedEventManagementSystemCSharp.Form1();
            obj4.ShowDialog();
        }
    }
}
