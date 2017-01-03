/*
 *创建人：琚建飞
 *创建时间：2016/12/7 16:57:45
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
    public partial class frmModifyUserPassword : Form
    {
        public frmModifyUserPassword()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)  //点击确定按钮
        {
            if (txtUserName.Text=="")
            {
                MessageBox.Show("请输入用户名！","温馨提示");
                txtUserName.Focus();
            }
            else if (txtPassword.Text=="")
            {
                MessageBox.Show("请输入密码!","温馨提示");
                txtPassword.Focus();
            }
            else if (txtConfirmPassword.Text=="")
            {
                MessageBox.Show("请输入确认密码！","温馨提示");
                txtConfirmPassword.Focus();
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("新密码和确认密码不一致，请确认后重新输入！", "温馨提示");
                txtConfirmPassword.Text = "";
                txtConfirmPassword.Focus();
            }
            else
            {
                //判断用户是否存在
                BLL.User checkuser = new BLL.User();
                bool checkresult = checkuser.SelectUser(txtUserName.Text.Trim());
                if (checkresult == false)
                {
                    MessageBox.Show("用户名不存在，请重新输入！", "温馨提示");
                }
                else
                {
                    //将修改的密码导入到数据库
                    Model.User user = new Model.User();
                    user.username = txtUserName.Text.Trim();
                    user.password = txtPassword.Text;
                    BLL.User modifypassword = new BLL.User();
                    int result = modifypassword.ModifyPassword(user);
                    if (result > 0)
                    {
                        MessageBox.Show("密码修改成功！", "温馨提示");
                        txtConfirmPassword.Text = "";
                        txtPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("密码修改失败，请联系管理员！","温馨提示");
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
