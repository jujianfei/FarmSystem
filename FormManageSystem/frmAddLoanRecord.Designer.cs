namespace FormManageSystem
{
    partial class frmAddLoanRecord
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
            this.txtLoanNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoanPerNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.DateTimePicker();
            this.txtState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLoanNum
            // 
            this.txtLoanNum.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoanNum.Location = new System.Drawing.Point(479, 57);
            this.txtLoanNum.Name = "txtLoanNum";
            this.txtLoanNum.Size = new System.Drawing.Size(126, 29);
            this.txtLoanNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(352, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "归还状态：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(174, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 29);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(376, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "数量：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(67, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "设备名：";
            // 
            // txtLoanPerNo
            // 
            this.txtLoanPerNo.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoanPerNo.Location = new System.Drawing.Point(174, 123);
            this.txtLoanPerNo.Name = "txtLoanPerNo";
            this.txtLoanPerNo.Size = new System.Drawing.Size(154, 29);
            this.txtLoanPerNo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(65, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "借用日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(45, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "借用人编号：";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(522, 245);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 33);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTime
            // 
            this.txtTime.CustomFormat = "yyyy-MM-dd HH:mm:ss ";
            this.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTime.Location = new System.Drawing.Point(174, 187);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(154, 21);
            this.txtTime.TabIndex = 5;
            this.txtTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtState.FormattingEnabled = true;
            this.txtState.Items.AddRange(new object[] {
            "未归还",
            "已归还"});
            this.txtState.Location = new System.Drawing.Point(479, 123);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(126, 27);
            this.txtState.TabIndex = 11;
            this.txtState.Text = "未归还";
            // 
            // frmAddLoanRecord
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(650, 334);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoanPerNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoanNum);
            this.Controls.Add(this.label2);
            this.Name = "frmAddLoanRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备借出记录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoanNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoanPerNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker txtTime;
        private System.Windows.Forms.ComboBox txtState;
    }
}