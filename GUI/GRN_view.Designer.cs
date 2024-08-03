namespace GUI
{
    partial class GRN_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRN_view));
            this.dgvGrn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrn
            // 
            this.dgvGrn.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrn.Location = new System.Drawing.Point(44, 103);
            this.dgvGrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGrn.Name = "dgvGrn";
            this.dgvGrn.RowHeadersWidth = 51;
            this.dgvGrn.RowTemplate.Height = 24;
            this.dgvGrn.Size = new System.Drawing.Size(741, 321);
            this.dgvGrn.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "Phiếu Nhập Kho";
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(635, 431);
            this.btDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(151, 64);
            this.btDel.TabIndex = 33;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // GRN_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(809, 554);
            this.Controls.Add(this.dgvGrn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GRN_view";
            this.Text = "QuanLy_GRNcs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDel;
    }
}