namespace AdvancedEventManagementSystemCSharp
{
    partial class ViewFeedback
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventVDataSet1 = new AdvancedEventManagementSystemCSharp.EventVDataSet1();
            this.feedbackTableAdapter = new AdvancedEventManagementSystemCSharp.EventVDataSet1TableAdapters.feedbackTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventVDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(193, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "View Feedback";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.feedbackDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feedbackBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(89, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 311);
            this.dataGridView1.TabIndex = 46;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // feedbackDataGridViewTextBoxColumn
            // 
            this.feedbackDataGridViewTextBoxColumn.DataPropertyName = "feedback";
            this.feedbackDataGridViewTextBoxColumn.HeaderText = "feedback";
            this.feedbackDataGridViewTextBoxColumn.Name = "feedbackDataGridViewTextBoxColumn";
            // 
            // feedbackBindingSource
            // 
            this.feedbackBindingSource.DataMember = "feedback";
            this.feedbackBindingSource.DataSource = this.eventVDataSet1;
            // 
            // eventVDataSet1
            // 
            this.eventVDataSet1.DataSetName = "EventVDataSet1";
            this.eventVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackTableAdapter
            // 
            this.feedbackTableAdapter.ClearBeforeFill = true;
            // 
            // ViewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "ViewFeedback";
            this.Text = "ViewFeedback";
            this.Load += new System.EventHandler(this.ViewFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventVDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EventVDataSet1 eventVDataSet1;
        private System.Windows.Forms.BindingSource feedbackBindingSource;
        private EventVDataSet1TableAdapters.feedbackTableAdapter feedbackTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackDataGridViewTextBoxColumn;
    }
}