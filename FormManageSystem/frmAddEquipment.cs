/*
 *创建人：琚建飞
 *创建时间：2016/12/7 20:11:34
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
    public partial class frmAddEquipment : Form
    {
        public frmAddEquipment()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)  //点击确认按钮
        {
            //new一个设备信息实体对象
            Model.Equipment equipment = new Model.Equipment();
            //从前台获取输入的数据
            equipment.name = txtName.Text.Trim();
            equipment.sum = txtNum.Text.Trim();
            equipment.mno = txtNo.Text.Trim();
            equipment.time = txtTime.Text.Trim();
            //将数据存入数据库
            BLL.Equipment addequipment = new BLL.Equipment();
            bool result=addequipment.AddEquipment(equipment);
            if (result == true)
            {
                MessageBox.Show("添加设备成功！", "温馨提示");
            }
            else
            {
                MessageBox.Show("添加设备失败！", "温馨提示");
            }
        }

        private void frmAddEquipment_Load(object sender, EventArgs e) //添加设备按钮
        {
            DateTime dt = DateTime.Now;
            txtTime.Text = dt.ToString();
        }

        private void txtTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
