/*
 *创建人：琚建飞
 *创建时间：2016/12/10 20:53:29
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
    public partial class frmModifyLoanRecord : Form
    {
        public frmModifyLoanRecord()
        {
            InitializeComponent();
        }

        private void frmModifyLoanRecord_Load(object sender, EventArgs e) //窗体加载事件
        {
            BLL.Equipment equipment = new BLL.Equipment();
            DataTable dt = equipment.SelectLoanInfoByName(Model.OverAllData.equipmentname);
            txtName.Text = dt.Rows[0][1].ToString().Trim();
            txtLoanPerNo.Text = dt.Rows[0][2].ToString().Trim();
            txtLoanNum.Text = dt.Rows[0][3].ToString().Trim();
            txtTime.Text = dt.Rows[0][4].ToString().Trim();
            txtState.Text = dt.Rows[0][5].ToString().Trim();
        }

        private void btnOk_Click(object sender, EventArgs e) //点击修改按钮
        {
            Model.LoanRecord record = new Model.LoanRecord();
            record.name = txtName.Text.Trim();
            record.loanpno = txtLoanPerNo.Text.Trim();
            record.num = txtLoanNum.Text.Trim();
            record.time = txtTime.Text.Trim();
            record.state = txtState.Text.Trim();

            BLL.Equipment equipment = new BLL.Equipment();
            int result = equipment.updateRecord(record);
            if (result > 0)
            {
                MessageBox.Show("数据修改成功！", "温馨提示");
            }
            else
            {
                MessageBox.Show("数据修改失败，请联系管理员！", "温馨提示");
            }
        }
    }
}
