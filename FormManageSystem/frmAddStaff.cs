using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormManageSystem
{
    public partial class frmAddStaff : Form
    {
        public frmAddStaff()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)     //添加员工信息
        {
            //new一个员工信息实体对象
            Model.Staff staffinfo = new Model.Staff();
            //获取前台输入的数据
            staffinfo.name = txtName.Text.Trim();
            staffinfo.age = txtAge.Text.Trim();
            staffinfo.school = txtSchool.Text.Trim();
            staffinfo.level = txtLevel.Text.Trim();
            staffinfo.money = txtMoney.Text.Trim();
            string departmentname = cboDepartment.Text.Trim();
            BLL.Staff staff = new BLL.Staff();
            int no = staff.CheckDepartmentNoByName(departmentname);
            staffinfo.departmentno = no;
            //将前台获取的数据存入到数据库
            BLL.Staff addstaff = new BLL.Staff();
            bool result = addstaff.AddUser(staffinfo);
            if (result==true)
            {
                MessageBox.Show("添加成功！","温馨提示");
            }
            else
            {
                MessageBox.Show("添加失败！","温馨提示");
            }
        }
    }
}
