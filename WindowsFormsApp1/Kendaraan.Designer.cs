namespace WindowsFormsApp1
{
    partial class Kendaraan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDMobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nopolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalMobilDataSet1 = new WindowsFormsApp1.RentalMobilDataSet1();
            this.rentalMobilDataSet = new WindowsFormsApp1.RentalMobilDataSet();
            this.rentalMobilDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WindowsFormsApp1.RentalMobilDataSetTableAdapters.CustomerTableAdapter();
            this.kendaraanTableAdapter = new WindowsFormsApp1.RentalMobilDataSet1TableAdapters.KendaraanTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.tb_nopol = new System.Windows.Forms.TextBox();
            this.tb_namaker = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Kendaraan";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 175);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            // kendaraanBindingSource
            // 
            this.kendaraanBindingSource.DataMember = "Kendaraan";
            this.kendaraanBindingSource.DataSource = this.rentalMobilDataSet1;
            // 
            // rentalMobilDataSet1
            // 
            this.rentalMobilDataSet1.DataSetName = "RentalMobilDataSet1";
            this.rentalMobilDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentalMobilDataSet
            // 
            this.rentalMobilDataSet.DataSetName = "RentalMobilDataSet";
            this.rentalMobilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentalMobilDataSetBindingSource
            // 
            this.rentalMobilDataSetBindingSource.DataSource = this.rentalMobilDataSet;
            this.rentalMobilDataSetBindingSource.Position = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.rentalMobilDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // kendaraanTableAdapter
            // 
            this.kendaraanTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Harga Sewa";
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(585, 236);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(125, 20);
            this.tb_harga.TabIndex = 45;
            // 
            // tb_nopol
            // 
            this.tb_nopol.Location = new System.Drawing.Point(585, 191);
            this.tb_nopol.Name = "tb_nopol";
            this.tb_nopol.Size = new System.Drawing.Size(125, 20);
            this.tb_nopol.TabIndex = 44;
            // 
            // tb_namaker
            // 
            this.tb_namaker.Location = new System.Drawing.Point(585, 144);
            this.tb_namaker.Name = "tb_namaker";
            this.tb_namaker.Size = new System.Drawing.Size(125, 20);
            this.tb_namaker.TabIndex = 43;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(585, 106);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(125, 20);
            this.tb_id.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "No Polisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nama Kendaraan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Id";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(533, 313);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 47;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(614, 313);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 48;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(695, 313);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 49;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 41);
            this.button1.TabIndex = 50;
            this.button1.Text = "<-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(614, 271);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 51;
            this.done.Text = "DONE";
            this.done.UseVisualStyleBackColor = true;
            this.done.Visible = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // Kendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.done);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.tb_nopol);
            this.Controls.Add(this.tb_namaker);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Kendaraan";
            this.Text = "Kendaraan";
            this.Load += new System.EventHandler(this.Kendaraan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rentalMobilDataSetBindingSource;
        private RentalMobilDataSet rentalMobilDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private RentalMobilDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private RentalMobilDataSet1 rentalMobilDataSet1;
        private System.Windows.Forms.BindingSource kendaraanBindingSource;
        private RentalMobilDataSet1TableAdapters.KendaraanTableAdapter kendaraanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.TextBox tb_nopol;
        private System.Windows.Forms.TextBox tb_namaker;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button done;
    }
}