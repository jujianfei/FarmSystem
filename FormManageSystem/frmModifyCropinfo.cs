/*
 *创建人：琚建飞
 *创建时间：2016/12/8 16:47:52
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
    public partial class frmModifyCropinfo : Form
    {
        public frmModifyCropinfo()
        {
            InitializeComponent();
        }

        private void frmModifyCropinfo_Load(object sender, EventArgs e) //窗体加载事件
        {
            //从全局变量中获取农作物名字并赋值给cropname
            string cropname = Model.OverAllData.cropname;
            //通过农作物名称查找对应的信息并显示在界面上
            BLL.Crops cropinfo = new BLL.Crops();
            DataTable dt = cropinfo.SelectCropByName(cropname);
            txtName.Text = (dt.Rows[0][0]).ToString();
            txtarea.Text = (dt.Rows[0][1]).ToString();
            txtMno.Text = (dt.Rows[0][2]).ToString();
        }

        private void btnOk_Click_1(object sender, EventArgs e)//点击确定按钮
        {
            //获取界面上修改后的值
            Model.Crops cropinfo = new Model.Crops();
            cropinfo.name = txtName.Text.Trim();
            cropinfo.area = txtarea.Text.Trim();
            cropinfo.mno = txtMno.Text.Trim();
            //以农作物实体的形式传递到后台进行更新
            BLL.Crops crop = new BLL.Crops();
            int result = crop.ModifyCropinfo(cropinfo);
            //返回确认信息
            if (result > 0)
            {
                MessageBox.Show("修改信息成功！", "温馨提示");
            }
            else
            {
                MessageBox.Show("修改信息失败，请联系管理员！", "温馨提示");
            }
        }
    }
}
