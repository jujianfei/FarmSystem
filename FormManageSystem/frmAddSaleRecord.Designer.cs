namespace FormManageSystem
{
    partial class frmAddSaleRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtNowNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rabAnimal = new System.Windows.Forms.RadioButton();
            this.rabCrops = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.DateTimePicker();
            this.txtTransportPerson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(74, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(148, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtSale
            // 
            this.txtSale.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSale.Location = new System.Drawing.Point(451, 85);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(178, 26);
            this.txtSale.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(373, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "卖　出：";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(532, 255);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 29);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(70, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "现有量：";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(148, 179);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(84, 26);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "点击查看";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.txtCheck_Click);
            // 
            // txtNowNum
            // 
            this.txtNowNum.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNowNum.Location = new System.Drawing.Point(148, 178);
            this.txtNowNum.Name = "txtNowNum";
            this.txtNowNum.Size = new System.Drawing.Size(178, 26);
            this.txtNowNum.TabIndex = 9;
            this.txtNowNum.Visible = false;
            this.txtNowNum.TextChanged += new System.EventHandler(this.txtNowNum_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(58, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "所属类别：";
            // 
            // rabAnimal
            // 
            this.rabAnimal.AutoSize = true;
            this.rabAnimal.Checked = true;
            this.rabAnimal.Location = new System.Drawing.Point(148, 137);
            this.rabAnimal.Name = "rabAnimal";
            this.rabAnimal.Size = new System.Drawing.Size(47, 16);
            this.rabAnimal.TabIndex = 2;
            this.rabAnimal.TabStop = true;
            this.rabAnimal.Text = "牲畜";
            this.rabAnimal.UseVisualStyleBackColor = true;
            // 
            // rabCrops
            // 
            this.rabCrops.AutoSize = true;
            this.rabCrops.Location = new System.Drawing.Point(249, 137);
            this.rabCrops.Name = "rabCrops";
            this.rabCrops.Size = new System.Drawing.Size(59, 16);
            this.rabCrops.TabIndex = 3;
            this.rabCrops.Text = "农作物";
            this.rabCrops.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(373, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "时　间：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTime
            // 
            this.txtTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.txtTime.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTime.Location = new System.Drawing.Point(451, 178);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(178, 23);
            this.txtTime.TabIndex = 7;
            // 
            // txtTransportPerson
            // 
            this.txtTransportPerson.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTransportPerson.Location = new System.Drawing.Point(451, 132);
            this.txtTransportPerson.Name = "txtTransportPerson";
            this.txtTransportPerson.Size = new System.Drawing.Size(178, 26);
            this.txtTransportPerson.TabIndex = 6;
            this.txtTransportPerson.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(373, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "配送人：";
            // 
            // frmAddSaleRecord
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(700, 340);
            this.Controls.Add(this.txtTransportPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rabCrops);
            this.Controls.Add(this.rabAnimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNowNum);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddSaleRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加销售信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtNowNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rabAnimal;
        private System.Windows.Forms.RadioButton rabCrops;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtTime;
        private System.Windows.Forms.TextBox txtTransportPerson;
        private System.Windows.Forms.Label label6;
    }
}