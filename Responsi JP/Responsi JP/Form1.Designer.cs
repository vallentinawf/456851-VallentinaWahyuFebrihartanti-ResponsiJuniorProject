namespace Responsi_JP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblKaryawan = new System.Windows.Forms.Label();
            this.lblDepartemen = new System.Windows.Forms.Label();
            this.tbKaryawan = new System.Windows.Forms.TextBox();
            this.cbDepartemen = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvHR = new System.Windows.Forms.DataGridView();
            this.gbHR = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHR)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(41, 42);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(59, 26);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(34, 15);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Logo";
            // 
            // lblKaryawan
            // 
            this.lblKaryawan.AutoSize = true;
            this.lblKaryawan.Location = new System.Drawing.Point(12, 99);
            this.lblKaryawan.Name = "lblKaryawan";
            this.lblKaryawan.Size = new System.Drawing.Size(99, 15);
            this.lblKaryawan.TabIndex = 2;
            this.lblKaryawan.Text = "Nama Karyawan :";
            // 
            // lblDepartemen
            // 
            this.lblDepartemen.AutoSize = true;
            this.lblDepartemen.Location = new System.Drawing.Point(12, 128);
            this.lblDepartemen.Name = "lblDepartemen";
            this.lblDepartemen.Size = new System.Drawing.Size(91, 15);
            this.lblDepartemen.TabIndex = 3;
            this.lblDepartemen.Text = "Dep. Karyawan :";
            // 
            // tbKaryawan
            // 
            this.tbKaryawan.Location = new System.Drawing.Point(130, 96);
            this.tbKaryawan.Name = "tbKaryawan";
            this.tbKaryawan.Size = new System.Drawing.Size(146, 23);
            this.tbKaryawan.TabIndex = 4;
            // 
            // cbDepartemen
            // 
            this.cbDepartemen.FormattingEnabled = true;
            this.cbDepartemen.Location = new System.Drawing.Point(130, 125);
            this.cbDepartemen.Name = "cbDepartemen";
            this.cbDepartemen.Size = new System.Drawing.Size(146, 23);
            this.cbDepartemen.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 179);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 33);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(187, 179);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 33);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvHR
            // 
            this.dgvHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHR.Location = new System.Drawing.Point(12, 218);
            this.dgvHR.Name = "dgvHR";
            this.dgvHR.RowTemplate.Height = 25;
            this.dgvHR.Size = new System.Drawing.Size(437, 150);
            this.dgvHR.TabIndex = 9;
            // 
            // gbHR
            // 
            this.gbHR.Location = new System.Drawing.Point(314, 38);
            this.gbHR.Name = "gbHR";
            this.gbHR.Size = new System.Drawing.Size(135, 119);
            this.gbHR.TabIndex = 10;
            this.gbHR.TabStop = false;
            this.gbHR.Text = "groupBox1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(361, 374);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 33);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(130, 67);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(146, 23);
            this.tbId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Karyawan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 417);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gbHR);
            this.Controls.Add(this.dgvHR);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbDepartemen);
            this.Controls.Add(this.tbKaryawan);
            this.Controls.Add(this.lblDepartemen);
            this.Controls.Add(this.lblKaryawan);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pbLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbLogo;
        private Label lblLogo;
        private Label lblKaryawan;
        private Label lblDepartemen;
        private TextBox tbKaryawan;
        private ComboBox cbDepartemen;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvHR;
        private GroupBox gbHR;
        private Button btnLoad;
        private TextBox tbId;
        private Label label1;
    }
}