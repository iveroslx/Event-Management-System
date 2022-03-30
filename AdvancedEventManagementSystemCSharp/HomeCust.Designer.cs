namespace AdvancedEventManagementSystemCSharp
{
    partial class HomeCust
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
            this.bookEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVenuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookEventToolStripMenuItem,
            this.bookingStatusToolStripMenuItem,
            this.giveFeedbackToolStripMenuItem,
            this.viewVenuesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookEventToolStripMenuItem
            // 
            this.bookEventToolStripMenuItem.Name = "bookEventToolStripMenuItem";
            this.bookEventToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.bookEventToolStripMenuItem.Text = "Book Event";
            this.bookEventToolStripMenuItem.Click += new System.EventHandler(this.bookEventToolStripMenuItem_Click);
            // 
            // bookingStatusToolStripMenuItem
            // 
            this.bookingStatusToolStripMenuItem.Name = "bookingStatusToolStripMenuItem";
            this.bookingStatusToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.bookingStatusToolStripMenuItem.Text = "Booking Status";
            this.bookingStatusToolStripMenuItem.Click += new System.EventHandler(this.bookingStatusToolStripMenuItem_Click);
            // 
            // giveFeedbackToolStripMenuItem
            // 
            this.giveFeedbackToolStripMenuItem.Name = "giveFeedbackToolStripMenuItem";
            this.giveFeedbackToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.giveFeedbackToolStripMenuItem.Text = "Give Feedback";
            this.giveFeedbackToolStripMenuItem.Click += new System.EventHandler(this.giveFeedbackToolStripMenuItem_Click);
            // 
            // viewVenuesToolStripMenuItem
            // 
            this.viewVenuesToolStripMenuItem.Name = "viewVenuesToolStripMenuItem";
            this.viewVenuesToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.viewVenuesToolStripMenuItem.Text = "View Venues";
            this.viewVenuesToolStripMenuItem.Click += new System.EventHandler(this.viewVenuesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HomeCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 439);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeCust";
            this.Text = "HomeCust";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVenuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}