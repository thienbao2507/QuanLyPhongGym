namespace GUI
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            this.txtMS = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.dgvEq = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.btGRN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGrn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGrnID = new System.Windows.Forms.TextBox();
            this.btView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEq)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMS
            // 
            this.txtMS.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMS.Location = new System.Drawing.Point(287, 386);
            this.txtMS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(307, 38);
            this.txtMS.TabIndex = 30;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(287, 284);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(307, 38);
            this.txtQuantity.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(287, 144);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 38);
            this.txtName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(104)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 81);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản Lý Thiết Bị";
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(173, 508);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(100, 80);
            this.btEdit.TabIndex = 32;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(53, 508);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(100, 80);
            this.btSubmit.TabIndex = 31;
            this.btSubmit.Text = "Thêm";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên Thiết bị";
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(301, 508);
            this.btDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(100, 80);
            this.btDel.TabIndex = 33;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // dgvEq
            // 
            this.dgvEq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEq.Location = new System.Drawing.Point(644, 30);
            this.dgvEq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEq.Name = "dgvEq";
            this.dgvEq.RowHeadersWidth = 51;
            this.dgvEq.RowTemplate.Height = 24;
            this.dgvEq.Size = new System.Drawing.Size(603, 606);
            this.dgvEq.TabIndex = 34;
            this.dgvEq.SelectionChanged += new System.EventHandler(this.dgvEq_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 437);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mô tả";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(288, 438);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(307, 38);
            this.txtDescription.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nhà cung cấp";
            // 
            // cbSupplier
            // 
            this.cbSupplier.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(287, 235);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(307, 38);
            this.cbSupplier.TabIndex = 35;
            // 
            // btGRN
            // 
            this.btGRN.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGRN.Location = new System.Drawing.Point(536, 593);
            this.btGRN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGRN.Name = "btGRN";
            this.btGRN.Size = new System.Drawing.Size(85, 42);
            this.btGRN.TabIndex = 36;
            this.btGRN.Text = "Xuất";
            this.btGRN.UseVisualStyleBackColor = true;
            this.btGRN.Click += new System.EventHandler(this.btGRN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.label7.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 30);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số phiếu nhập kho";
            // 
            // txtGrn
            // 
            this.txtGrn.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrn.Location = new System.Drawing.Point(285, 190);
            this.txtGrn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrn.Name = "txtGrn";
            this.txtGrn.Size = new System.Drawing.Size(307, 38);
            this.txtGrn.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.label8.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 30);
            this.label8.TabIndex = 26;
            this.label8.Text = "Đơn giá";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(285, 335);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(307, 38);
            this.txtUnitPrice.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 599);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 30);
            this.label9.TabIndex = 25;
            this.label9.Text = "Xuất phiếu nhập kho cho số:";
            // 
            // txtGrnID
            // 
            this.txtGrnID.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrnID.Location = new System.Drawing.Point(395, 596);
            this.txtGrnID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrnID.Name = "txtGrnID";
            this.txtGrnID.Size = new System.Drawing.Size(132, 38);
            this.txtGrnID.TabIndex = 37;
            // 
            // btView
            // 
            this.btView.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btView.Location = new System.Drawing.Point(431, 508);
            this.btView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(164, 80);
            this.btView.TabIndex = 33;
            this.btView.Text = "Xem phiếu nhập kho";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1261, 660);
            this.Controls.Add(this.txtGrnID);
            this.Controls.Add(this.btGRN);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.dgvEq);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtGrn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btDel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.DataGridView dgvEq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Button btGRN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGrn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGrnID;
        private System.Windows.Forms.Button btView;
    }
}