namespace GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbNameE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIdEmployee = new System.Windows.Forms.Label();
            this.btEmployee = new System.Windows.Forms.Button();
            this.btMembers = new System.Windows.Forms.Button();
            this.btEquipment = new System.Windows.Forms.Button();
            this.btSupplier = new System.Windows.Forms.Button();
            this.btGymService = new System.Windows.Forms.Button();
            this.btReceipt = new System.Windows.Forms.Button();
            this.lbRank = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.lb4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(207)))), ((int)(((byte)(222)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin Chào:";
            // 
            // lbNameE
            // 
            this.lbNameE.AutoSize = true;
            this.lbNameE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(207)))), ((int)(((byte)(222)))));
            this.lbNameE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameE.Location = new System.Drawing.Point(161, 25);
            this.lbNameE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameE.Name = "lbNameE";
            this.lbNameE.Size = new System.Drawing.Size(194, 29);
            this.lbNameE.TabIndex = 2;
            this.lbNameE.Text = "nameEmployee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(207)))), ((int)(((byte)(222)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // lbIdEmployee
            // 
            this.lbIdEmployee.AutoSize = true;
            this.lbIdEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(207)))), ((int)(((byte)(222)))));
            this.lbIdEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdEmployee.Location = new System.Drawing.Point(673, 25);
            this.lbIdEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdEmployee.Name = "lbIdEmployee";
            this.lbIdEmployee.Size = new System.Drawing.Size(155, 29);
            this.lbIdEmployee.TabIndex = 4;
            this.lbIdEmployee.Text = "IDEmployee";
            // 
            // btEmployee
            // 
            this.btEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee.Location = new System.Drawing.Point(595, 342);
            this.btEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Size = new System.Drawing.Size(392, 73);
            this.btEmployee.TabIndex = 5;
            this.btEmployee.Text = "Quản lý nhân viên";
            this.btEmployee.UseVisualStyleBackColor = true;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // btMembers
            // 
            this.btMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMembers.Location = new System.Drawing.Point(93, 124);
            this.btMembers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMembers.Name = "btMembers";
            this.btMembers.Size = new System.Drawing.Size(392, 73);
            this.btMembers.TabIndex = 6;
            this.btMembers.Text = "Quản lý thành viên";
            this.btMembers.UseVisualStyleBackColor = true;
            this.btMembers.Click += new System.EventHandler(this.btMembers_Click);
            // 
            // btEquipment
            // 
            this.btEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEquipment.Location = new System.Drawing.Point(595, 124);
            this.btEquipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEquipment.Name = "btEquipment";
            this.btEquipment.Size = new System.Drawing.Size(392, 73);
            this.btEquipment.TabIndex = 7;
            this.btEquipment.Text = "Quản lý thiết bị";
            this.btEquipment.UseVisualStyleBackColor = true;
            this.btEquipment.Click += new System.EventHandler(this.btEquipment_Click);
            // 
            // btSupplier
            // 
            this.btSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupplier.Location = new System.Drawing.Point(93, 342);
            this.btSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSupplier.Name = "btSupplier";
            this.btSupplier.Size = new System.Drawing.Size(392, 73);
            this.btSupplier.TabIndex = 8;
            this.btSupplier.Text = "Quản lý nhà cung cấp";
            this.btSupplier.UseVisualStyleBackColor = true;
            this.btSupplier.Click += new System.EventHandler(this.btSupplier_Click);
            // 
            // btGymService
            // 
            this.btGymService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGymService.Location = new System.Drawing.Point(595, 233);
            this.btGymService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGymService.Name = "btGymService";
            this.btGymService.Size = new System.Drawing.Size(392, 73);
            this.btGymService.TabIndex = 7;
            this.btGymService.Text = "Quản lý gói tập";
            this.btGymService.UseVisualStyleBackColor = true;
            this.btGymService.Click += new System.EventHandler(this.btGymService_Click);
            // 
            // btReceipt
            // 
            this.btReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReceipt.Location = new System.Drawing.Point(93, 233);
            this.btReceipt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReceipt.Name = "btReceipt";
            this.btReceipt.Size = new System.Drawing.Size(392, 73);
            this.btReceipt.TabIndex = 7;
            this.btReceipt.Text = "Quản lý hóa đơn";
            this.btReceipt.UseVisualStyleBackColor = true;
            this.btReceipt.Click += new System.EventHandler(this.btReceipt_Click);
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(207)))), ((int)(((byte)(222)))));
            this.lbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.Location = new System.Drawing.Point(949, 25);
            this.lbRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(97, 29);
            this.lbRank.TabIndex = 10;
            this.lbRank.Text = "RankID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(207)))), ((int)(((byte)(222)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(857, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rank:";
            // 
            // btLogout
            // 
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(772, 492);
            this.btLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(279, 73);
            this.btLogout.TabIndex = 11;
            this.btLogout.Text = "Đăng Xuất";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // lb4
            // 
            this.lb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(234, 126);
            this.lb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(621, 212);
            this.lb4.TabIndex = 12;
            this.lb4.Text = "Bạn không có quyền quản lý";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1056, 567);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSupplier);
            this.Controls.Add(this.btReceipt);
            this.Controls.Add(this.btGymService);
            this.Controls.Add(this.btEquipment);
            this.Controls.Add(this.btMembers);
            this.Controls.Add(this.btEmployee);
            this.Controls.Add(this.lbIdEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNameE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNameE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIdEmployee;
        private System.Windows.Forms.Button btEmployee;
        private System.Windows.Forms.Button btMembers;
        private System.Windows.Forms.Button btEquipment;
        private System.Windows.Forms.Button btSupplier;
        private System.Windows.Forms.Button btGymService;
        private System.Windows.Forms.Button btReceipt;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label lb4;
    }
}