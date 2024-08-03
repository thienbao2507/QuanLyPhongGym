namespace GUI
{
    partial class GymService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymService));
            this.dgvGs = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGs
            // 
            this.dgvGs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGs.Location = new System.Drawing.Point(637, 43);
            this.dgvGs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGs.Name = "dgvGs";
            this.dgvGs.RowHeadersWidth = 51;
            this.dgvGs.RowTemplate.Height = 24;
            this.dgvGs.Size = new System.Drawing.Size(588, 599);
            this.dgvGs.TabIndex = 47;
            this.dgvGs.SelectionChanged += new System.EventHandler(this.dgvGs_SelectionChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(271, 368);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(307, 38);
            this.txtDescription.TabIndex = 42;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(269, 310);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(307, 38);
            this.txtDuration.TabIndex = 43;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(269, 251);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(307, 38);
            this.txtPrice.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(269, 194);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 38);
            this.txtName.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 38;
            this.label5.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Thời hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 37;
            this.label3.Text = "Giá cả";
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(269, 537);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(100, 58);
            this.btEdit.TabIndex = 45;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(97, 537);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(100, 58);
            this.btSubmit.TabIndex = 44;
            this.btSubmit.Text = "Thêm";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên gói tập";
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(428, 537);
            this.btDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(100, 58);
            this.btDel.TabIndex = 46;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(104)))));
            this.label6.Font = new System.Drawing.Font("Roboto", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(43, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(529, 81);
            this.label6.TabIndex = 48;
            this.label6.Text = "Quản Lý Gói Tập";
            // 
            // GymService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1240, 656);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvGs);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GymService";
            this.Text = "GymSerivece";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGs;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label label6;
    }
}