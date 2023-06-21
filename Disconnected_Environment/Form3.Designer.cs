namespace Disconnected_Environment
{
    partial class Form3
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
            this.txbx_nim = new System.Windows.Forms.TextBox();
            this.cmb_jk = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_nama = new System.Windows.Forms.TextBox();
            this.txbx_alamat = new System.Windows.Forms.TextBox();
            this.cmb_prodi = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.mahasiswaDataSet = new Disconnected_Environment.MahasiswaDataSet();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new Disconnected_Environment.MahasiswaDataSetTableAdapters.mahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // txbx_nim
            // 
            this.txbx_nim.Location = new System.Drawing.Point(379, 115);
            this.txbx_nim.Multiline = true;
            this.txbx_nim.Name = "txbx_nim";
            this.txbx_nim.Size = new System.Drawing.Size(405, 53);
            this.txbx_nim.TabIndex = 1;
            this.txbx_nim.TextChanged += new System.EventHandler(this.txbx_nim_TextChanged);
            // 
            // cmb_jk
            // 
            this.cmb_jk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_jk.FormattingEnabled = true;
            this.cmb_jk.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cmb_jk.Location = new System.Drawing.Point(379, 273);
            this.cmb_jk.Name = "cmb_jk";
            this.cmb_jk.Size = new System.Drawing.Size(121, 39);
            this.cmb_jk.TabIndex = 2;
            this.cmb_jk.SelectedIndexChanged += new System.EventHandler(this.cmb_jk_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 420);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 40);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(130, 582);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(172, 74);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jenis kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tanggal lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prodi";
            // 
            // txbx_nama
            // 
            this.txbx_nama.Location = new System.Drawing.Point(379, 201);
            this.txbx_nama.Multiline = true;
            this.txbx_nama.Name = "txbx_nama";
            this.txbx_nama.Size = new System.Drawing.Size(405, 53);
            this.txbx_nama.TabIndex = 11;
            this.txbx_nama.TextChanged += new System.EventHandler(this.txbx_nama_TextChanged);
            // 
            // txbx_alamat
            // 
            this.txbx_alamat.Location = new System.Drawing.Point(379, 330);
            this.txbx_alamat.Multiline = true;
            this.txbx_alamat.Name = "txbx_alamat";
            this.txbx_alamat.Size = new System.Drawing.Size(405, 53);
            this.txbx_alamat.TabIndex = 12;
            this.txbx_alamat.TextChanged += new System.EventHandler(this.txbx_alamat_TextChanged);
            // 
            // cmb_prodi
            // 
            this.cmb_prodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_prodi.FormattingEnabled = true;
            this.cmb_prodi.IntegralHeight = false;
            this.cmb_prodi.ItemHeight = 37;
            this.cmb_prodi.Location = new System.Drawing.Point(379, 494);
            this.cmb_prodi.Name = "cmb_prodi";
            this.cmb_prodi.Size = new System.Drawing.Size(405, 45);
            this.cmb_prodi.TabIndex = 13;
            this.cmb_prodi.SelectedIndexChanged += new System.EventHandler(this.cmb_prodi_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(379, 582);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(172, 74);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(612, 582);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(172, 74);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // mahasiswaDataSet
            // 
            this.mahasiswaDataSet.DataSetName = "MahasiswaDataSet";
            this.mahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.mahasiswaDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 811);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_prodi);
            this.Controls.Add(this.txbx_alamat);
            this.Controls.Add(this.txbx_nama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_jk);
            this.Controls.Add(this.txbx_nim);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_nim;
        private System.Windows.Forms.ComboBox cmb_jk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_nama;
        private System.Windows.Forms.TextBox txbx_alamat;
        private System.Windows.Forms.ComboBox cmb_prodi;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private MahasiswaDataSet mahasiswaDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private MahasiswaDataSetTableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter;
    }
}