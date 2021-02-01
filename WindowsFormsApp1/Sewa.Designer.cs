namespace WindowsFormsApp1
{
    partial class Sewa
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
            this.label1 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.tb_hari = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcust = new System.Windows.Forms.ComboBox();
            this.rentalMobilDataSet3 = new WindowsFormsApp1.RentalMobilDataSet3();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WindowsFormsApp1.RentalMobilDataSet3TableAdapters.CustomerTableAdapter();
            this.tbmobs = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentalMobilDataSet4 = new WindowsFormsApp1.RentalMobilDataSet4();
            this.kendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kendaraanTableAdapter = new WindowsFormsApp1.RentalMobilDataSet4TableAdapters.KendaraanTableAdapter();
            this.iDMobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nopolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pendaftaran Customer";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.next.Location = new System.Drawing.Point(90, 301);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(248, 23);
            this.next.TabIndex = 22;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // tb_hari
            // 
            this.tb_hari.Location = new System.Drawing.Point(176, 243);
            this.tb_hari.Name = "tb_hari";
            this.tb_hari.Size = new System.Drawing.Size(43, 20);
            this.tb_hari.TabIndex = 20;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel.Location = new System.Drawing.Point(88, 341);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(248, 23);
            this.cancel.TabIndex = 23;
            this.cancel.Text = "Cancle";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nama Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Jenis Kendaraan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tgl Sewa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Berapa Hari";
            // 
            // tbcust
            // 
            this.tbcust.DataSource = this.customerBindingSource;
            this.tbcust.DisplayMember = "Nama";
            this.tbcust.FormattingEnabled = true;
            this.tbcust.Location = new System.Drawing.Point(176, 106);
            this.tbcust.Name = "tbcust";
            this.tbcust.Size = new System.Drawing.Size(121, 21);
            this.tbcust.TabIndex = 29;
            this.tbcust.ValueMember = "ID_Customer";
            // 
            // rentalMobilDataSet3
            // 
            this.rentalMobilDataSet3.DataSetName = "RentalMobilDataSet3";
            this.rentalMobilDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.rentalMobilDataSet3;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tbmobs
            // 
            this.tbmobs.DataSource = this.kendaraanBindingSource;
            this.tbmobs.DisplayMember = "Nama_Kendaraan";
            this.tbmobs.FormattingEnabled = true;
            this.tbmobs.Location = new System.Drawing.Point(176, 142);
            this.tbmobs.Name = "tbmobs";
            this.tbmobs.Size = new System.Drawing.Size(121, 21);
            this.tbmobs.TabIndex = 30;
            this.tbmobs.ValueMember = "ID_Mobil";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Total";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(176, 270);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(94, 20);
            this.tb_total.TabIndex = 32;
            this.tb_total.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMobilDataGridViewTextBoxColumn,
            this.namaKendaraanDataGridViewTextBoxColumn,
            this.nopolDataGridViewTextBoxColumn,
            this.hargasewaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kendaraanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(331, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 153);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // rentalMobilDataSet4
            // 
            this.rentalMobilDataSet4.DataSetName = "RentalMobilDataSet4";
            this.rentalMobilDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kendaraanBindingSource
            // 
            this.kendaraanBindingSource.DataMember = "Kendaraan";
            this.kendaraanBindingSource.DataSource = this.rentalMobilDataSet4;
            // 
            // kendaraanTableAdapter
            // 
            this.kendaraanTableAdapter.ClearBeforeFill = true;
            // 
            // iDMobilDataGridViewTextBoxColumn
            // 
            this.iDMobilDataGridViewTextBoxColumn.DataPropertyName = "ID_Mobil";
            this.iDMobilDataGridViewTextBoxColumn.HeaderText = "ID_Mobil";
            this.iDMobilDataGridViewTextBoxColumn.Name = "iDMobilDataGridViewTextBoxColumn";
            this.iDMobilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaKendaraanDataGridViewTextBoxColumn
            // 
            this.namaKendaraanDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kendaraan";
            this.namaKendaraanDataGridViewTextBoxColumn.HeaderText = "Nama_Kendaraan";
            this.namaKendaraanDataGridViewTextBoxColumn.Name = "namaKendaraanDataGridViewTextBoxColumn";
            // 
            // nopolDataGridViewTextBoxColumn
            // 
            this.nopolDataGridViewTextBoxColumn.DataPropertyName = "Nopol";
            this.nopolDataGridViewTextBoxColumn.HeaderText = "Nopol";
            this.nopolDataGridViewTextBoxColumn.Name = "nopolDataGridViewTextBoxColumn";
            // 
            // hargasewaDataGridViewTextBoxColumn
            // 
            this.hargasewaDataGridViewTextBoxColumn.DataPropertyName = "Harga_sewa";
            this.hargasewaDataGridViewTextBoxColumn.HeaderText = "Harga_sewa";
            this.hargasewaDataGridViewTextBoxColumn.Name = "hargasewaDataGridViewTextBoxColumn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(331, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Kendaraan Yang Terrsedia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Harga Sewa";
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(176, 213);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(94, 20);
            this.tb_harga.TabIndex = 37;
            this.tb_harga.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 20);
            this.button1.TabIndex = 38;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbmobs);
            this.Controls.Add(this.tbcust);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.next);
            this.Controls.Add(this.tb_hari);
            this.Controls.Add(this.label1);
            this.Name = "Sewa";
            this.Text = "w";
            this.Load += new System.EventHandler(this.Sewa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox tb_hari;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tbcust;
        private RentalMobilDataSet3 rentalMobilDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private RentalMobilDataSet3TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ComboBox tbmobs;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RentalMobilDataSet4 rentalMobilDataSet4;
        private System.Windows.Forms.BindingSource kendaraanBindingSource;
        private RentalMobilDataSet4TableAdapters.KendaraanTableAdapter kendaraanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.Button button1;
    }
}