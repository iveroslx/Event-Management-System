namespace AdvancedEventManagementSystemCSharp
{
    partial class BookingHistory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noguestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookeventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventVDataSet3 = new AdvancedEventManagementSystemCSharp.EventVDataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.book_eventTableAdapter = new AdvancedEventManagementSystemCSharp.EventVDataSet3TableAdapters.book_eventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookeventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventVDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.etypeDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.noguestDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.equipDataGridViewTextBoxColumn,
            this.ftypeDataGridViewTextBoxColumn,
            this.foodDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookeventBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etypeDataGridViewTextBoxColumn
            // 
            this.etypeDataGridViewTextBoxColumn.DataPropertyName = "e_type";
            this.etypeDataGridViewTextBoxColumn.HeaderText = "e_type";
            this.etypeDataGridViewTextBoxColumn.Name = "etypeDataGridViewTextBoxColumn";
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // noguestDataGridViewTextBoxColumn
            // 
            this.noguestDataGridViewTextBoxColumn.DataPropertyName = "no_guest";
            this.noguestDataGridViewTextBoxColumn.HeaderText = "no_guest";
            this.noguestDataGridViewTextBoxColumn.Name = "noguestDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // equipDataGridViewTextBoxColumn
            // 
            this.equipDataGridViewTextBoxColumn.DataPropertyName = "equip";
            this.equipDataGridViewTextBoxColumn.HeaderText = "equip";
            this.equipDataGridViewTextBoxColumn.Name = "equipDataGridViewTextBoxColumn";
            // 
            // ftypeDataGridViewTextBoxColumn
            // 
            this.ftypeDataGridViewTextBoxColumn.DataPropertyName = "f_type";
            this.ftypeDataGridViewTextBoxColumn.HeaderText = "f_type";
            this.ftypeDataGridViewTextBoxColumn.Name = "ftypeDataGridViewTextBoxColumn";
            // 
            // foodDataGridViewTextBoxColumn
            // 
            this.foodDataGridViewTextBoxColumn.DataPropertyName = "food";
            this.foodDataGridViewTextBoxColumn.HeaderText = "food";
            this.foodDataGridViewTextBoxColumn.Name = "foodDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // bookeventBindingSource
            // 
            this.bookeventBindingSource.DataMember = "book_event";
            this.bookeventBindingSource.DataSource = this.eventVDataSet3;
            // 
            // eventVDataSet3
            // 
            this.eventVDataSet3.DataSetName = "EventVDataSet3";
            this.eventVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(250, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Booking History";
            // 
            // book_eventTableAdapter
            // 
            this.book_eventTableAdapter.ClearBeforeFill = true;
            // 
            // BookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookingHistory";
            this.Text = "BookingHistory";
            this.Load += new System.EventHandler(this.BookingHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookeventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventVDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private EventVDataSet3 eventVDataSet3;
        private System.Windows.Forms.BindingSource bookeventBindingSource;
        private EventVDataSet3TableAdapters.book_eventTableAdapter book_eventTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noguestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}