/*
 *创建人：琚建飞
 *创建时间：2016/12/7 16:17:26
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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)  //点击添加按钮
        {
            if (txtUserName.Text.Trim()=="")
            {
                MessageBox.Show("请输入用户名！","温馨提示");
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！", "温馨提示");
            }
            else if (cboLevel.Text.Trim() == "")
            {
                MessageBox.Show("请输入职位！", "温馨提示");
            }
            else
            {
                //判断用户是否存在
                BLL.User checkuser = new BLL.User();
                bool checkresult = checkuser.SelectUser(txtUserName.Text.Trim());
                if (checkresult == true)
                {
                    MessageBox.Show("用户名已存在，请重新输入！", "温馨提示");
                    txtUserName.Text = "";
                    txtUserName.Focus();
                }
                else
                {
                    //new一个登录用户实体
                    Model.User user = new Model.User();
                    //从界面获取添加的数据
                    user.username = txtUserName.Text.Trim();
                    user.password = txtPassword.Text.Trim();
                    user.level = cboLevel.Text.Trim();
                    //将数据传递给数据库
                    BLL.User adduser = new BLL.User();
                    int result = adduser.AddUser(user);
                    if (result > 0)
                    {
                        MessageBox.Show("添加用户成功！", "温馨提示");
                    }
                    else
                    {
                        MessageBox.Show("添加用户失败，请联系管理员！", "温馨提示");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) //点击取消按钮
        {
            this.Dispose();
        }
    }
}
