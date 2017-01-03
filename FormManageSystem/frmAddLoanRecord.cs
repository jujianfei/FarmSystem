/*
 *创建人：琚建飞
 *创建时间：2016/12/10 19:33:17
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormManageSystem
{
    public partial class frmAddLoanRecord : Form
    {
        public frmAddLoanRecord()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e) //确定添加按钮
        {
            Model.LoanRecord record = new Model.LoanRecord();
            record.name = txtName.Text.Trim();
            record.loanpno = txtLoanPerNo.Text.Trim();
            record.num = txtLoanNum.Text.Trim();
            record.time = txtTime.Text.Trim();
            record.state = txtState.Text.Trim();

            BLL.Equipment equipment = new BLL.Equipment();
            int result = equipment.AddLoanRecord(record);
            if (result > 0)
            {
                MessageBox.Show("添加信息成功！", "温馨提示");
                //更新数据库中对应设备的数量
                string equipmentname = txtName.Text.Trim();
                int loannum = Convert.ToInt32(txtLoanNum.Text.Trim());
                equipment.Update(equipmentname,loannum);
            }
            else
            {
                MessageBox.Show("添加信息失败，请联系管理员！", "温馨提示");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
