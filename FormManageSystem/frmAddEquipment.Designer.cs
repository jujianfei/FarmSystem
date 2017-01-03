namespace FormManageSystem
{
    partial class frmAddEquipment
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(332, 272);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 32);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum.Location = new System.Drawing.Point(198, 115);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(219, 29);
            this.txtNum.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(103, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "数　量：";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNo.Location = new System.Drawing.Point(198, 166);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(219, 29);
            this.txtNo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(66, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "负责人编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(86, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "购买时间：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(198, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 29);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(103, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "设备名：";
            // 
            // txtTime
            // 
            this.txtTime.CustomFormat = "yyyy-MM-dd HH:mm:ss ";
            this.txtTime.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTime.Location = new System.Drawing.Point(198, 213);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(219, 26);
            this.txtTime.TabIndex = 4;
            this.txtTime.Value = new System.DateTime(2016, 12, 10, 21, 42, 28, 0);
            this.txtTime.ValueChanged += new System.EventHandler(this.txtTime_ValueChanged);
            // 
            // frmAddEquipment
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(463, 364);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加设备";
            this.Load += new System.EventHandler(this.frmAddEquipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtTime;
    }
}