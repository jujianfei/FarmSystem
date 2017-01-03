/*
 *创建人：琚建飞
 *创建时间：2016/12/8 16:22:18
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
    public partial class frmAddCrop : Form
    {
        public frmAddCrop()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) //点击确定按钮
        { 
            //new一个crop实体
            Model.Crops cropinfo = new Model.Crops();
            //将界面输入的数据赋值给crop实体
            cropinfo.name = txtName.Text.Trim();
            cropinfo.area = txtarea.Text.Trim();
            cropinfo.mno = txtMno.Text.Trim();
            //将数据传入数据库
            BLL.Crops addcrop = new BLL.Crops();
            int result = addcrop.AddCropinfo(cropinfo);
            if (result > 0)
            {
                MessageBox.Show("添加信息成功！", "温馨提示");
            }
            else
            {
                MessageBox.Show("添加信息失败，请联系管理员！","温馨提示");
            }
        }
    }
}
