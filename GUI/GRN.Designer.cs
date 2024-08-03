namespace GUI
{
    partial class GRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRN));
            this.dgvEq = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btView = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDate1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEq)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEq
            // 
            this.dgvEq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEq.Location = new System.Drawing.Point(132, 297);
            this.dgvEq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEq.Name = "dgvEq";
            this.dgvEq.RowHeadersWidth = 51;
            this.dgvEq.RowTemplate.Height = 24;
            this.dgvEq.Size = new System.Drawing.Size(1101, 260);
            this.dgvEq.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 52);
            this.label1.TabIndex = 57;
            this.label1.Text = "PHIẾU NHẬP KHO";
            // 
            // btView
            // 
            this.btView.AccessibleName = "Preview";
            this.btView.Location = new System.Drawing.Point(1103, 833);
            this.btView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(132, 78);
            this.btView.TabIndex = 61;
            this.btView.Text = "Xem phiếu nhập kho";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.AccessibleName = "btSubmit";
            this.btSubmit.Location = new System.Drawing.Point(974, 833);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(121, 78);
            this.btSubmit.TabIndex = 60;
            this.btSubmit.Text = "Xuất phiếu";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "PHỎNG GYM ABC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 25);
            this.label6.TabIndex = 69;
            this.label6.Text = "45 đường X, phường Y, quận Z, TPHCM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "- Họ và tên người giao:";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(948, 585);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 46);
            this.label25.TabIndex = 0;
            this.label25.Text = "Tổng tiền:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "- Nhập tại kho: PHÒNG GYM ABC";
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupplier.Location = new System.Drawing.Point(357, 230);
            this.lbSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(103, 26);
            this.lbSupplier.TabIndex = 73;
            this.lbSupplier.Text = "-------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 700);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "Người lập phiếu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 725);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "(Ký, họ tên)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 700);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 74;
            this.label9.Text = "Người giao hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(643, 700);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 74;
            this.label11.Text = "Thủ kho";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(893, 700);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 25);
            this.label13.TabIndex = 74;
            this.label13.Text = "Kế toán trưởng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(437, 725);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 74;
            this.label10.Text = "(Ký, họ tên)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(636, 725);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 25);
            this.label12.TabIndex = 74;
            this.label12.Text = "(Ký, họ tên)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(913, 725);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 25);
            this.label14.TabIndex = 74;
            this.label14.Text = "(Ký, họ tên)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(147, 625);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(271, 24);
            this.label15.TabIndex = 75;
            this.label15.Text = "Tồng số tiền (viết bằng chữ):";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(435, 626);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(242, 25);
            this.lbTotal.TabIndex = 76;
            this.lbTotal.Text = "..............................................";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(563, 145);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(250, 25);
            this.lbDate.TabIndex = 70;
            this.lbDate.Text = "Ngày xx tháng xx năm xxxx";
            // 
            // lbDate1
            // 
            this.lbDate1.AutoSize = true;
            this.lbDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate1.Location = new System.Drawing.Point(845, 676);
            this.lbDate1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate1.Name = "lbDate1";
            this.lbDate1.Size = new System.Drawing.Size(250, 25);
            this.lbDate1.TabIndex = 70;
            this.lbDate1.Text = "Ngày xx tháng xx năm xxxx";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(1073, 585);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(125, 46);
            this.txtTongTien.TabIndex = 0;
            this.txtTongTien.Text = "Tổng tiền:";
            this.txtTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(252, 833);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(360, 30);
            this.txtNote.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 827);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Note:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 1055);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDate1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvEq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtNote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GRN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvEq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDate1;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label5;
    }
}