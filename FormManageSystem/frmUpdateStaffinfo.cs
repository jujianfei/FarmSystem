/*
 *创建人：琚建飞
 *创建时间：2016/12/7 12:03:09
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
    public partial class frmUpdateStaffinfo : Form
    {
        public frmUpdateStaffinfo()
        {
            InitializeComponent();
        }

        private void frmUpdateStaffinfo_Load(object sender, EventArgs e)  //窗体加载事件
        {
            //从全局变量中获取员工编号并从数据库中查询出编号对应的一行信息
            BLL.Staff staffinfo = new BLL.Staff();
            DataTable dt = staffinfo.SelectStaffInfo(Model.OverAllData.sno);
            //将查询的结果显示在界面上
            cboDepartment.Text = (dt.Rows[0][1]).ToString();
            txtName.Text = (dt.Rows[0][2]).ToString();
            txtLevel.Text= (dt.Rows[0][6]).ToString();
            txtAge.Text = (dt.Rows[0][3]).ToString();
            txtSchool.Text = (dt.Rows[0][4]).ToString();
            txtMoney.Text= (dt.Rows[0][5]).ToString();
            
        }

        private void btnOk_Click(object sender, EventArgs e) //单击确定按钮事件
        {
           
        }

        private void btnOk_Click_1(object sender, EventArgs e) //单击确定按钮事件
        {
            Model.Staff staffinfo = new Model.Staff();
            //将文本框中信息写入到Model.Staff
            staffinfo.name = txtName.Text.Trim();
            staffinfo.age = txtAge.Text.Trim();
            staffinfo.school = txtSchool.Text.Trim();
            staffinfo.money = txtMoney.Text.Trim();
            staffinfo.level = txtLevel.Text.Trim();
            staffinfo.departmentno = Convert.ToInt32(cboDepartment.Text.Trim());
            staffinfo.no =Convert.ToInt32 (Model.OverAllData.sno);
            //将实体传到后台进行更新
            BLL.Staff info = new BLL.Staff();
            int result = info.ModifyStaffInfo(staffinfo);

            if (result > 0)
            {
                MessageBox.Show("修改成功", "温馨提示");
            }
            else
            {
                MessageBox.Show("修改失败！请联系管理员！", "温馨提示");
            }
        }
    }
}
