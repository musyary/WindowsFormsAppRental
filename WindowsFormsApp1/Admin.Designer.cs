namespace WindowsFormsApp1
{
    partial class Admin
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
            this.iDCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalMobilDataSet = new WindowsFormsApp1.RentalMobilDataSet();
            this.update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.customerTableAdapter = new WindowsFormsApp1.RentalMobilDataSetTableAdapters.CustomerTableAdapter();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.tb_telp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_nik = new System.Windows.Forms.TextBox();
            this.tb_sim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Customer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCustomerDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.nikDataGridViewTextBoxColumn,
            this.nosimDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 203);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // iDCustomerDataGridViewTextBoxColumn
            // 
            this.iDCustomerDataGridViewTextBoxColumn.DataPropertyName = "ID_Customer";
            this.iDCustomerDataGridViewTextBoxColumn.HeaderText = "ID_Customer";
            this.iDCustomerDataGridViewTextBoxColumn.Name = "iDCustomerDataGridViewTextBoxColumn";
            this.iDCustomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // nikDataGridViewTextBoxColumn
            // 
            this.nikDataGridViewTextBoxColumn.DataPropertyName = "Nik";
            this.nikDataGridViewTextBoxColumn.HeaderText = "Nik";
            this.nikDataGridViewTextBoxColumn.Name = "nikDataGridViewTextBoxColumn";
            // 
            // nosimDataGridViewTextBoxColumn
            // 
            this.nosimDataGridViewTextBoxColumn.DataPropertyName = "No_sim";
            this.nosimDataGridViewTextBoxColumn.HeaderText = "No_sim";
            this.nosimDataGridViewTextBoxColumn.Name = "nosimDataGridViewTextBoxColumn";
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "No_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "No_telp";
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.rentalMobilDataSet;
            // 
            // rentalMobilDataSet
            // 
            this.rentalMobilDataSet.DataSetName = "RentalMobilDataSet";
            this.rentalMobilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.ForestGreen;
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(526, 198);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(98, 32);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Crimson;
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(630, 198);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 32);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(304, 111);
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(128, 20);
            this.tb_alamat.TabIndex = 32;
            // 
            // tb_telp
            // 
            this.tb_telp.Location = new System.Drawing.Point(304, 71);
            this.tb_telp.Name = "tb_telp";
            this.tb_telp.Size = new System.Drawing.Size(128, 20);
            this.tb_telp.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 41);
            this.button1.TabIndex = 37;
            this.button1.Text = "<-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "NIK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "No Telpon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Alamat";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(98, 71);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(125, 20);
            this.tb_id.TabIndex = 28;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(98, 109);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(125, 20);
            this.tb_nama.TabIndex = 29;
            // 
            // tb_nik
            // 
            this.tb_nik.Location = new System.Drawing.Point(98, 156);
            this.tb_nik.Name = "tb_nik";
            this.tb_nik.Size = new System.Drawing.Size(125, 20);
            this.tb_nik.TabIndex = 30;
            // 
            // tb_sim
            // 
            this.tb_sim.Location = new System.Drawing.Point(98, 201);
            this.tb_sim.Name = "tb_sim";
            this.tb_sim.Size = new System.Drawing.Size(125, 20);
            this.tb_sim.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "No SIM";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumTurquoise;
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Location = new System.Drawing.Point(422, 198);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(98, 32);
            this.add.TabIndex = 38;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button2_Click);
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.ForestGreen;
            this.done.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.done.Location = new System.Drawing.Point(320, 144);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(98, 32);
            this.done.TabIndex = 39;
            this.done.Text = "DONE";
            this.done.UseVisualStyleBackColor = false;
            this.done.Visible = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.done);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_sim);
            this.Controls.Add(this.tb_alamat);
            this.Controls.Add(this.tb_telp);
            this.Controls.Add(this.tb_nik);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalMobilDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Delete;
        private RentalMobilDataSet rentalMobilDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private RentalMobilDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.TextBox tb_telp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_nik;
        private System.Windows.Forms.TextBox tb_sim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button done;
    }
}