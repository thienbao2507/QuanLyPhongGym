namespace GUI
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.dgvSup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(256, 370);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(307, 38);
            this.txtAddress.TabIndex = 18;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(256, 287);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(307, 38);
            this.txtSdt.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(256, 203);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 38);
            this.txtName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Bk", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 81);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(437, 528);
            this.btDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(127, 86);
            this.btDel.TabIndex = 22;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(252, 528);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(127, 86);
            this.btEdit.TabIndex = 21;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(67, 528);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(127, 86);
            this.btSubmit.TabIndex = 20;
            this.btSubmit.Text = "Thêm";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // dgvSup
            // 
            this.dgvSup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.dgvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSup.Location = new System.Drawing.Point(649, 130);
            this.dgvSup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSup.Name = "dgvSup";
            this.dgvSup.RowHeadersWidth = 51;
            this.dgvSup.RowTemplate.Height = 24;
            this.dgvSup.Size = new System.Drawing.Size(581, 518);
            this.dgvSup.TabIndex = 23;
            this.dgvSup.SelectionChanged += new System.EventHandler(this.dgvEM_SelectionChanged);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1245, 662);
            this.Controls.Add(this.dgvSup);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Supplier";
            this.Text = "Nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.DataGridView dgvSup;
    }
}