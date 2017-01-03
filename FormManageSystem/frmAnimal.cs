/*
 *创建人：琚建飞
 *创建时间：2016/12/8 20:14:51
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
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
        }

        private void frmAnimal_Load(object sender, EventArgs e) //窗体加载
        {
            BindData();
        }

        private void BindData() //绑定数据表信息
        {
            BLL.Animal animal = new BLL.Animal();
            DataTable dt = animal.ReturnAllAnimalInfo();
            dataGridView1.DataSource = dt;
        }

        private void toolStripButton7_Click(object sender, EventArgs e) //点击刷新按钮
        {
            BindData();
        }

        private void toolStripButton6_Click(object sender, EventArgs e) //点击退出按钮
        {
            this.Dispose();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //点击修改按钮
        {
            if (mark3)
            {
                mark3 = !mark3; //取消选中
                frmModifyAnimal f = new frmModifyAnimal();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选中一条记录再进行操作！");
            }
        }

        bool mark3 = false;
        #region 选中dataGridView的某行的某个单元格
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)      //单击某一行
            {
                mark3 = true;
                Model.OverAllData.animalname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value); //获取某行的第一个单元格的数据传给全局变量sno
            }
        }
        #endregion

        private void toolStripButton3_Click(object sender, EventArgs e) //单击删除按钮
        {
            if (mark3)
            {
                mark3 = !mark3;//取消选中
                BLL.Animal animal = new BLL.Animal();
                int result = animal.DeleteAnimal(Model.OverAllData.animalname);
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
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //点击增加按钮
        {
            frmAddAnimal f = new frmAddAnimal();
            f.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e) //单击查找按钮
        {
            if (txtCheck.Text == "")
            {
                MessageBox.Show("请输入查询条件！", "温馨提示");
            }
            else
            {
                if (rabtSno.Checked)
                {
                    //根据负责人号查询牲畜信息
                    string mno = txtCheck.Text.Trim();
                    BLL.Animal animal = new BLL.Animal();
                    DataTable dt = animal.SelectAnimalByMno(mno);
                    if (dt.Rows.Count == 0) //判断返回值是否为空
                    {
                        MessageBox.Show("抱歉，没有此编号的牲畜信息，请确认后输入！", "温馨提示");
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                    }
                }
                else
                {
                    //根据姓名查询农作物信息
                    string name = txtCheck.Text.Trim();
                    BLL.Animal animal2 = new BLL.Animal();
                    DataTable dt2 = animal2.SelectAnimalByName(name);
                    if (dt2.Rows.Count == 0) //判断返回值是否为空
                    {
                        MessageBox.Show("抱歉，没有此名称的农作物，请确认后输入！", "温馨提示");
                    }
                    else
                    {
                        dataGridView1.DataSource = dt2;
                    }
                }
            }
        }
    }
}
