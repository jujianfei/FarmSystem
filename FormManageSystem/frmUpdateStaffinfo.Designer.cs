namespace FormManageSystem
{
    partial class frmUpdateStaffinfo
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
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Items.AddRange(new object[] {
            "销售部",
            "人事部",
            "设备部",
            "生产部"});
            this.cboDepartment.Location = new System.Drawing.Point(421, 208);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(131, 24);
            this.cboDepartment.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(460, 282);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 28);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(181, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 26);
            this.txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(110, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "姓名：";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAge.Location = new System.Drawing.Point(421, 96);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(131, 26);
            this.txtAge.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(350, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "年龄：";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoney.Location = new System.Drawing.Point(421, 145);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(132, 26);
            this.txtMoney.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(350, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "工资：";
            // 
            // txtLevel
            // 
            this.txtLevel.Enabled = false;
            this.txtLevel.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLevel.Location = new System.Drawing.Point(183, 208);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(130, 26);
            this.txtLevel.TabIndex = 20;
            this.txtLevel.Text = "员工";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(112, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "职位：";
            // 
            // txtSchool
            // 
            this.txtSchool.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSchool.Location = new System.Drawing.Point(181, 145);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(132, 26);
            this.txtSchool.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(110, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "学历：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(350, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "部门：";
            // 
            // frmUpdateStaffinfo
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(662, 407);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateStaffinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新员工信息";
            this.Load += new System.EventHandler(this.frmUpdateStaffinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}