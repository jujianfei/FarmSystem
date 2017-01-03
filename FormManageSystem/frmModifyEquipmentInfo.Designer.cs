namespace FormManageSystem
{
    partial class frmModifyEquipmentInfo
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
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(333, 302);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 32);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSum.Location = new System.Drawing.Point(219, 106);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(199, 29);
            this.txtSum.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(124, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "总数量：";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNo.Location = new System.Drawing.Point(219, 202);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(199, 29);
            this.txtNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(87, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "负责人编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(107, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "购买时间：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(219, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 29);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(124, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "设备名：";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStock.Location = new System.Drawing.Point(219, 154);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(199, 29);
            this.txtStock.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(124, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "库存量：";
            // 
            // txtTime
            // 
            this.txtTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.txtTime.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTime.Location = new System.Drawing.Point(222, 249);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(199, 26);
            this.txtTime.TabIndex = 5;
            // 
            // frmModifyEquipmentInfo
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(536, 393);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmModifyEquipmentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改设备信息";
            this.Load += new System.EventHandler(this.frmMondifyEquipmentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtTime;

    }
}