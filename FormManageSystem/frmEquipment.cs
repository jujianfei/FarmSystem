/*
 *创建人：琚建飞
 *创建时间：2016/12/7 19:53:49
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
    public partial class frmEquipment : Form
    {
        public frmEquipment()
        {
            InitializeComponent();
        }

        private void frmEquipment_Load(object sender, EventArgs e) //窗体加载
        {
            BindData();
        }

        private void BindData() //重新绑定数据
        {
            BLL.Equipment equipment = new BLL.Equipment();
            DataTable dt = equipment.EquipmentInfo();
            dataGridView1.DataSource = dt;
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //点击添加按钮
        {
            frmAddEquipment f = new frmAddEquipment();
            f.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e) //刷新按钮
        {
            BindData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //点击修改按钮
        {
            if (mark3)
            {
                mark3 = !mark3; //取消选中
                frmModifyEquipmentInfo f = new frmModifyEquipmentInfo();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选中一条记录再进行操作！");
            }
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e) //窗体退出按钮
        {
            this.Dispose();
        }

        bool mark3 = false;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)      //单击某一行
            {
                mark3 = true;
                Model.OverAllData.equipmentname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value); //获取某行的第一个单元格的数据传给全局变量sno
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //删除按钮
        {
            if (mark3)
            {
                mark3 = !mark3;//取消选中
                BLL.Equipment deleteequipment = new BLL.Equipment();
                int result = deleteequipment.DeleteEquipmentInfo(Model.OverAllData.equipmentname);
                if (result > 0)
                {
                    MessageBox.Show("删除成功！", "温馨提示");
                    BindData();
                }
                else
                {
                    MessageBox.Show("删除失败，请联系管理员！", "温馨提示");
                }
            }
            else
            {
                MessageBox.Show("请选中一条记录再进行操作！");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e) //点击查询按钮
        {
            if (txtCheck.Text == "")  //判断是否输入查询条件
            {
                MessageBox.Show("请输入查询条件！", "温馨提示");
                txtCheck.Focus();
            }
            else
            {
                if (rabtSno.Checked)
                {
                    //根据设备号查询设备信息
                    string equipmentmno = txtCheck.Text.Trim();
                    BLL.Equipment equipmentinfo = new BLL.Equipment();
                    DataTable dt = equipmentinfo.SelectEquipmentInfo(equipmentmno);
                    dataGridView1.DataSource = dt;
                }
                else
                { 
                    //根据名称查询设备信息
                    string equipmentname = txtCheck.Text.Trim();
                    BLL.Equipment info = new BLL.Equipment();
                    DataTable dt2 = info.SelectEquipmentByName(equipmentname);
                    dataGridView1.DataSource = dt2;
                }
            }
        }
    }
}
