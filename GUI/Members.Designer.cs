namespace GUI
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.joiningDate = new System.Windows.Forms.DateTimePicker();
            this.dOBKH = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdFemaleKH = new System.Windows.Forms.RadioButton();
            this.rdMaleKH = new System.Windows.Forms.RadioButton();
            this.txtPhoneKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtHoKH = new System.Windows.Forms.TextBox();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.txtAddressKH = new System.Windows.Forms.TextBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSer = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.btFindID = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCus);
            this.groupBox1.Location = new System.Drawing.Point(879, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1085, 640);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvCus
            // 
            this.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCus.Location = new System.Drawing.Point(3, 17);
            this.dgvCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCus.Name = "dgvCus";
            this.dgvCus.RowHeadersWidth = 51;
            this.dgvCus.RowTemplate.Height = 24;
            this.dgvCus.Size = new System.Drawing.Size(1079, 621);
            this.dgvCus.TabIndex = 0;
            this.dgvCus.SelectionChanged += new System.EventHandler(this.dgvCus_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(104)))));
            this.label1.Font = new System.Drawing.Font("Roboto Bk", 50.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 30);
            this.label9.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 673);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 30);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã gói tập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày tham gia";
            // 
            // joiningDate
            // 
            this.joiningDate.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joiningDate.Location = new System.Drawing.Point(385, 581);
            this.joiningDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.joiningDate.Name = "joiningDate";
            this.joiningDate.Size = new System.Drawing.Size(353, 38);
            this.joiningDate.TabIndex = 8;
            // 
            // dOBKH
            // 
            this.dOBKH.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBKH.Location = new System.Drawing.Point(385, 362);
            this.dOBKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dOBKH.Name = "dOBKH";
            this.dOBKH.Size = new System.Drawing.Size(353, 38);
            this.dOBKH.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdFemaleKH);
            this.groupBox3.Controls.Add(this.rdMaleKH);
            this.groupBox3.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(385, 470);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(355, 43);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // rdFemaleKH
            // 
            this.rdFemaleKH.AutoSize = true;
            this.rdFemaleKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemaleKH.Location = new System.Drawing.Point(216, 9);
            this.rdFemaleKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdFemaleKH.Name = "rdFemaleKH";
            this.rdFemaleKH.Size = new System.Drawing.Size(106, 30);
            this.rdFemaleKH.TabIndex = 1;
            this.rdFemaleKH.Text = "Female";
            this.rdFemaleKH.UseVisualStyleBackColor = true;
            // 
            // rdMaleKH
            // 
            this.rdMaleKH.AutoSize = true;
            this.rdMaleKH.Checked = true;
            this.rdMaleKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaleKH.Location = new System.Drawing.Point(31, 9);
            this.rdMaleKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMaleKH.Name = "rdMaleKH";
            this.rdMaleKH.Size = new System.Drawing.Size(80, 30);
            this.rdMaleKH.TabIndex = 0;
            this.rdMaleKH.TabStop = true;
            this.rdMaleKH.Text = "Male";
            this.rdMaleKH.UseVisualStyleBackColor = true;
            // 
            // txtPhoneKH
            // 
            this.txtPhoneKH.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneKH.Location = new System.Drawing.Point(385, 421);
            this.txtPhoneKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneKH.Name = "txtPhoneKH";
            this.txtPhoneKH.Size = new System.Drawing.Size(353, 38);
            this.txtPhoneKH.TabIndex = 13;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(385, 303);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(353, 38);
            this.txtTenKH.TabIndex = 13;
            // 
            // txtHoKH
            // 
            this.txtHoKH.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoKH.Location = new System.Drawing.Point(385, 244);
            this.txtHoKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoKH.Name = "txtHoKH";
            this.txtHoKH.Size = new System.Drawing.Size(353, 38);
            this.txtHoKH.TabIndex = 13;
            // 
            // txtMS
            // 
            this.txtMS.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMS.Location = new System.Drawing.Point(385, 630);
            this.txtMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(353, 38);
            this.txtMS.TabIndex = 13;
            // 
            // txtAddressKH
            // 
            this.txtAddressKH.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressKH.Location = new System.Drawing.Point(385, 526);
            this.txtAddressKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressKH.Name = "txtAddressKH";
            this.txtAddressKH.Size = new System.Drawing.Size(353, 38);
            this.txtAddressKH.TabIndex = 13;
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(367, 757);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(99, 63);
            this.btEdit.TabIndex = 14;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(160, 757);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(119, 63);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(553, 757);
            this.btDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(107, 63);
            this.btDel.TabIndex = 14;
            this.btDel.Text = "Xoá";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(132, 626);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Trạng thái";
            // 
            // cbSer
            // 
            this.cbSer.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSer.FormattingEnabled = true;
            this.cbSer.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105"});
            this.cbSer.Location = new System.Drawing.Point(385, 677);
            this.cbSer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSer.Name = "cbSer";
            this.cbSer.Size = new System.Drawing.Size(353, 38);
            this.cbSer.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(104)))));
            this.label13.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(1029, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 30);
            this.label13.TabIndex = 42;
            this.label13.Text = "Nhập tên cần tìm :";
            // 
            // txtFindName
            // 
            this.txtFindName.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindName.Location = new System.Drawing.Point(1241, 52);
            this.txtFindName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(403, 38);
            this.txtFindName.TabIndex = 43;
            // 
            // btFindID
            // 
            this.btFindID.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFindID.Location = new System.Drawing.Point(1677, 47);
            this.btFindID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFindID.Name = "btFindID";
            this.btFindID.Size = new System.Drawing.Size(127, 48);
            this.btFindID.TabIndex = 44;
            this.btFindID.Text = "Tìm";
            this.btFindID.UseVisualStyleBackColor = true;
            this.btFindID.Click += new System.EventHandler(this.btFindID_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(1812, 47);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(127, 48);
            this.btRefresh.TabIndex = 45;
            this.btRefresh.Text = "Làm Mới";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 875);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFindName);
            this.Controls.Add(this.btFindID);
            this.Controls.Add(this.cbSer);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.txtAddressKH);
            this.Controls.Add(this.txtHoKH);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtPhoneKH);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dOBKH);
            this.Controls.Add(this.joiningDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker joiningDate;
        private System.Windows.Forms.DateTimePicker dOBKH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdFemaleKH;
        private System.Windows.Forms.RadioButton rdMaleKH;
        private System.Windows.Forms.TextBox txtPhoneKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtHoKH;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.TextBox txtAddressKH;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.Button btFindID;
        private System.Windows.Forms.Button btRefresh;
    }
}