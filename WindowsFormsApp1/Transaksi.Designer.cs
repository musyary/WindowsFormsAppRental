namespace WindowsFormsApp1
{
    partial class Transaksi
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
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalMobilDataSet2 = new WindowsFormsApp1.RentalMobilDataSet2();
            this.transaksiTableAdapter = new WindowsFormsApp1.RentalMobilDataSet2TableAdapters.TransaksiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentalMobilDataSet8 = new WindowsFormsApp1.RentalMobilDataSet8();
            this.transaksiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter1 = new WindowsFormsApp1.RentalMobilDataSet8TableAdapters.TransaksiTableAdapter();
            this.iDtransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglsewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.rentalMobilDataSet2;
            // 
            // rentalMobilDataSet2
            // 
            this.rentalMobilDataSet2.DataSetName = "RentalMobilDataSet2";
            this.rentalMobilDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDtransaksiDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.namaKendaraanDataGridViewTextBoxColumn,
            this.tglsewaDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.hariDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaksiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // rentalMobilDataSet8
            // 
            this.rentalMobilDataSet8.DataSetName = "RentalMobilDataSet8";
            this.rentalMobilDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiBindingSource1
            // 
            this.transaksiBindingSource1.DataMember = "Transaksi";
            this.transaksiBindingSource1.DataSource = this.rentalMobilDataSet8;
            // 
            // transaksiTableAdapter1
            // 
            this.transaksiTableAdapter1.ClearBeforeFill = true;
            // 
            // iDtransaksiDataGridViewTextBoxColumn
            // 
            this.iDtransaksiDataGridViewTextBoxColumn.DataPropertyName = "ID_transaksi";
            this.iDtransaksiDataGridViewTextBoxColumn.HeaderText = "ID_transaksi";
            this.iDtransaksiDataGridViewTextBoxColumn.Name = "iDtransaksiDataGridViewTextBoxColumn";
            this.iDtransaksiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // namaKendaraanDataGridViewTextBoxColumn
            // 
            this.namaKendaraanDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kendaraan";
            this.namaKendaraanDataGridViewTextBoxColumn.HeaderText = "Nama_Kendaraan";
            this.namaKendaraanDataGridViewTextBoxColumn.Name = "namaKendaraanDataGridViewTextBoxColumn";
            // 
            // tglsewaDataGridViewTextBoxColumn
            // 
            this.tglsewaDataGridViewTextBoxColumn.DataPropertyName = "tgl_sewa";
            this.tglsewaDataGridViewTextBoxColumn.HeaderText = "tgl_sewa";
            this.tglsewaDataGridViewTextBoxColumn.Name = "tglsewaDataGridViewTextBoxColumn";
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Sub_total";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Sub_total";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            // 
            // hariDataGridViewTextBoxColumn
            // 
            this.hariDataGridViewTextBoxColumn.DataPropertyName = "hari";
            this.hariDataGridViewTextBoxColumn.HeaderText = "hari";
            this.hariDataGridViewTextBoxColumn.Name = "hariDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaksi Penyewaan ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "<-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RentalMobilDataSet2 rentalMobilDataSet2;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private RentalMobilDataSet2TableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RentalMobilDataSet8 rentalMobilDataSet8;
        private System.Windows.Forms.BindingSource transaksiBindingSource1;
        private RentalMobilDataSet8TableAdapters.TransaksiTableAdapter transaksiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglsewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hariDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}