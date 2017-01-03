/*
 *创建人：琚建飞
 *创建时间：2016/12/7 21:05:51
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
    public partial class frmModifyEquipmentInfo : Form
    {
        public frmModifyEquipmentInfo()
        {
            InitializeComponent();
        }

        private void frmMondifyEquipmentInfo_Load(object sender, EventArgs e) //窗体显示并加载选中的信息
        {
            //从全局变量中获取设备编号并从数据库中读取对应的一行信息
            BLL.Equipment equipment = new BLL.Equipment();
            DataTable dt = equipment.SelectEquipmentByName(Model.OverAllData.equipmentname);
            //将从数据库中读取的信息显示到界面上
            txtName.Text = (dt.Rows[0][0]).ToString();
            txtSum.Text= (dt.Rows[0][1]).ToString();
            txtStock.Text = dt.Rows[0][2].ToString();
            txtNo.Text=(dt.Rows[0][3]).ToString();
            txtTime.Text = (dt.Rows[0][4]).ToString();
        }

        private void btnOk_Click_1(object sender, EventArgs e)//点击确认修改按钮
        {
            Model.Equipment equipmentinfo = new Model.Equipment();
            //将文本框中信息写入到Model.Equipment
            equipmentinfo.name = txtName.Text.Trim();
            equipmentinfo.sum = txtSum.Text.Trim();
            equipmentinfo.mno = txtNo.Text.Trim();
            equipmentinfo.time = txtTime.Text.Trim();
            equipmentinfo.stock = txtStock.Text.Trim();
            //将实体传给数据库进行更新
            BLL.Equipment info = new BLL.Equipment();
            int result = info.ModifyEquipmentInfo(equipmentinfo);
            if (result > 0)
            {
                MessageBox.Show("修改成功！", "温馨提示");
            }
            else
            {
                MessageBox.Show("修改失败，请联系管理员！", "温馨提示");
            }
        }
    }
}
