/*
 *创建人：琚建飞
 *创建时间：2016/12/8 16:15:06
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
    public partial class frmCrops : Form
    {
        public frmCrops()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //点击增加按钮
        {
            frmAddCrop f = new frmAddCrop();
            f.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //点击修改按钮
        {
            if (mark3)
            {
                mark3 = !mark3; //取消选中
                frmModifyCropinfo f = new frmModifyCropinfo();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选中一条记录再进行操作！");
            }
        }

        private void frmCrops_Load(object sender, EventArgs e) //窗体加载，显示数据库表中全部农作物信息
        {
            BindData();
        }

        private void BindData() //重新绑定数据
        {
            BLL.Crops crops = new BLL.Crops();
            DataTable dt = crops.ReturnCropsInfo();
            dataGridView1.DataSource = dt;
        }

        private void toolStripButton7_Click(object sender, EventArgs e) //点击刷新按钮
        {
            BindData();
        }

        bool mark3 = false;
        #region 选中dataGridView的某行的某个单元格
        /// <summary>
        ///  选中dataGridView的某行的某个单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)      //单击某一行
            {
                mark3 = true;
                Model.OverAllData.cropname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value); //获取某行的第一个单元格的数据传给全局变量sno
            }
        }
        #endregion

        private void toolStripButton3_Click(object sender, EventArgs e) //点击删除按钮
        {
            if (mark3)
            {
                mark3 = !mark3;//取消选中
                BLL.Crops crop = new BLL.Crops();
                int result = crop.DeleteCrop(Model.OverAllData.cropname);
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

        private void toolStripButton4_Click(object sender, EventArgs e) //点击查询按钮
        {
            if (txtCheck.Text == "")
            {
                MessageBox.Show("请输入查询条件！", "温馨提示");
            }
            else
            {
                if (rabtSno.Checked)
                {
                    //根据负责人号查询农作物信息
                    string cropmno = txtCheck.Text.Trim();
                    BLL.Crops crop = new BLL.Crops();
                    DataTable dt = crop.SelectCropByNo(cropmno);
                    if (dt.Rows.Count==0 ) //判断返回值是否为空
                    {
                        MessageBox.Show("抱歉，没有此编号的农作物，请确认后输入！", "温馨提示");
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
                    BLL.Crops crop2 = new BLL.Crops();
                    DataTable dt2 = crop2.SelectCropByName(name);
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

        private void toolStripButton6_Click(object sender, EventArgs e) //退出按钮
        {
            this.Dispose();
        }
    }
}
