namespace GUI
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.dgvHd = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btPreview = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.cbGS = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateHD = new System.Windows.Forms.DateTimePicker();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHd
            // 
            this.dgvHd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHd.Location = new System.Drawing.Point(32, 498);
            this.dgvHd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHd.Name = "dgvHd";
            this.dgvHd.RowHeadersWidth = 51;
            this.dgvHd.RowTemplate.Height = 24;
            this.dgvHd.Size = new System.Drawing.Size(1319, 468);
            this.dgvHd.TabIndex = 47;
            this.dgvHd.SelectionChanged += new System.EventHandler(this.dgvHd_SelectionChanged);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(885, 201);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(307, 32);
            this.txtNote.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(689, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "Gói tập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 52);
            this.label1.TabIndex = 35;
            this.label1.Text = "Quản Lý Hóa Đơn";
            // 
            // btPreview
            // 
            this.btPreview.AccessibleName = "Preview";
            this.btPreview.Location = new System.Drawing.Point(281, 433);
            this.btPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(111, 42);
            this.btPreview.TabIndex = 45;
            this.btPreview.Text = "Xem trước";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.AccessibleName = "btSubmit";
            this.btSubmit.Location = new System.Drawing.Point(109, 433);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(109, 42);
            this.btSubmit.TabIndex = 44;
            this.btSubmit.Text = "Xuất hóa đơn";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nhân viên";
            // 
            // btDel
            // 
            this.btDel.AccessibleName = "btDel";
            this.btDel.Location = new System.Drawing.Point(461, 433);
            this.btDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(116, 38);
            this.btDel.TabIndex = 46;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 26);
            this.label6.TabIndex = 48;
            this.label6.Text = "Thành tiền";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(629, 27);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(173, 26);
            this.lbTotal.TabIndex = 49;
            this.lbTotal.Text = "-----------------------";
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.Location = new System.Drawing.Point(200, 32);
            this.lbEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(173, 26);
            this.lbEmployee.TabIndex = 50;
            this.lbEmployee.Text = "-----------------------";
            // 
            // cbGS
            // 
            this.cbGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGS.FormattingEnabled = true;
            this.cbGS.Location = new System.Drawing.Point(143, 17);
            this.cbGS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGS.Name = "cbGS";
            this.cbGS.Size = new System.Drawing.Size(256, 33);
            this.cbGS.TabIndex = 51;
            this.cbGS.SelectedIndexChanged += new System.EventHandler(this.cbGS_SelectedIndexChanged);
            this.cbGS.TextChanged += new System.EventHandler(this.cbGS_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 26);
            this.label7.TabIndex = 39;
            this.label7.Text = "Ngày xuất hóa đơn";
            // 
            // dateHD
            // 
            this.dateHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHD.Location = new System.Drawing.Point(212, 90);
            this.dateHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateHD.Name = "dateHD";
            this.dateHD.Size = new System.Drawing.Size(380, 32);
            this.dateHD.TabIndex = 52;
            // 
            // cbMember
            // 
            this.cbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(885, 31);
            this.cbMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(307, 33);
            this.cbMember.TabIndex = 53;
            this.cbMember.SelectedIndexChanged += new System.EventHandler(this.cbMember_SelectedIndexChanged);
            this.cbMember.TextChanged += new System.EventHandler(this.cbMember_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMember);
            this.groupBox1.Controls.Add(this.lbEmployee);
            this.groupBox1.Controls.Add(this.dateHD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(36, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1256, 247);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(885, 144);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.ReadOnly = true;
            this.txtPhoneNum.Size = new System.Drawing.Size(307, 32);
            this.txtPhoneNum.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(689, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 26);
            this.label9.TabIndex = 38;
            this.label9.Text = "Điện thoại";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(885, 86);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(307, 32);
            this.txtAddress.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(689, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 26);
            this.label8.TabIndex = 38;
            this.label8.Text = "Địa chỉ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGS);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(36, 330);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1256, 96);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin gói tập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(616, 441);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 26);
            this.label10.TabIndex = 38;
            this.label10.Text = "Số hóa đơn:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHD.Location = new System.Drawing.Point(755, 437);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(307, 32);
            this.txtSoHD.TabIndex = 42;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(1100, 437);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(116, 38);
            this.btSearch.TabIndex = 56;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1397, 907);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Receipt";
            this.Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHd;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.ComboBox cbGS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateHD;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Button btSearch;
    }
}