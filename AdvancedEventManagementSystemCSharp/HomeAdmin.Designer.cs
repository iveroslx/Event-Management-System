namespace AdvancedEventManagementSystemCSharp
{
    partial class HomeAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addVenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVenueToolStripMenuItem,
            this.bookingHistoryToolStripMenuItem,
            this.bookingStatusToolStripMenuItem,
            this.viewFeedbackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addVenueToolStripMenuItem
            // 
            this.addVenueToolStripMenuItem.Name = "addVenueToolStripMenuItem";
            this.addVenueToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.addVenueToolStripMenuItem.Text = "Add Event";
            this.addVenueToolStripMenuItem.Click += new System.EventHandler(this.addVenueToolStripMenuItem_Click);
            // 
            // bookingHistoryToolStripMenuItem
            // 
            this.bookingHistoryToolStripMenuItem.Name = "bookingHistoryToolStripMenuItem";
            this.bookingHistoryToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.bookingHistoryToolStripMenuItem.Text = "Booking History";
            this.bookingHistoryToolStripMenuItem.Click += new System.EventHandler(this.bookingHistoryToolStripMenuItem_Click);
            // 
            // bookingStatusToolStripMenuItem
            // 
            this.bookingStatusToolStripMenuItem.Name = "bookingStatusToolStripMenuItem";
            this.bookingStatusToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.bookingStatusToolStripMenuItem.Text = "Booking Status";
            this.bookingStatusToolStripMenuItem.Click += new System.EventHandler(this.bookingStatusToolStripMenuItem_Click);
            // 
            // viewFeedbackToolStripMenuItem
            // 
            this.viewFeedbackToolStripMenuItem.Name = "viewFeedbackToolStripMenuItem";
            this.viewFeedbackToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.viewFeedbackToolStripMenuItem.Text = "View Feedback";
            this.viewFeedbackToolStripMenuItem.Click += new System.EventHandler(this.viewFeedbackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 27);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeAdmin";
            this.Text = "HomeAdmin";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addVenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}