using FormManageSystem;
/*
 *创建人：张婷
 *创建人：琚建飞
 *创建时间：2016/12/6 22:32:27
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e) //点击确定按钮
        {
            //new一个user实体
            Model.User selectuser = new Model.User();
            //将界面输入的值传给user实体
            selectuser.username = txtUserName.Text.Trim();
            selectuser.password = txtPassword.Text.Trim();
            if (selectuser.username == "")
            {
                MessageBox.Show("请输入用户名！", "温馨提示");
            }
            else if (selectuser.password == "")
            {
                MessageBox.Show("请输入密码！", "温馨提示");
            }
            else
            {
                //判断用户是否存在
                BLL.User checkuser = new BLL.User();
                bool checkresult = checkuser.SelectUser(selectuser.username);
                if (checkresult == false)
                {
                    MessageBox.Show("用户名不存在，请重新输入！", "温馨提示");
                }
                else
                {
                    //判断用户密码是否正确
                    BLL.User user = new BLL.User();
                    bool result = user.SelectUserPassword(selectuser);
                    if (result == true)
                    {
                        //判断登录权限
                        BLL.User level = new BLL.User();
                        Model.OverAllData.level = level.SelectUserLevel(txtUserName.Text.Trim());
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("密码错误，请重新输入！", "温馨提示");
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }
                }
            }
        }
    }
}
