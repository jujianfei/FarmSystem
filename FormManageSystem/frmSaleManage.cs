/*
 *创建人：琚建飞
 *创建时间：2016/12/11 12:50:46
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
    public partial class frmSaleManage : Form
    {
        public frmSaleManage()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //点击添加按钮
        {
            frmAddSaleRecord f = new frmAddSaleRecord();
            f.ShowDialog();
        }

        private void frmSaleManage_Load(object sender, EventArgs e) //窗体加载事件
        {
            BindData();
        }

        private void BindData()//绑定数据
        {
            BLL.SaleRecord record = new BLL.SaleRecord();
            DataTable dt = record.salerecord();
            dataGridView1.DataSource = dt;
        }

        private void toolStripButton7_Click(object sender, EventArgs e) //刷新按钮
        {
            BindData();
        }

        private void toolStripButton6_Click(object sender, EventArgs e) //退出按钮
        {
            this.Dispose();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //点击修改按钮
        {
            if (mark3)
            {
                mark3 = !mark3; //取消选中
                frmModifySaleRecord f = new frmModifySaleRecord();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选中一条记录再进行操作！");
            }
        }

        bool mark3 = false;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)      //单击某一行
            {
                mark3 = true;
                Model.OverAllData.salerecordname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value); //获取某行的第一个单元格的数据传给全局变量sno
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //删除按钮
        {
            if (mark3)
            {
                mark3 = !mark3;//取消选中
                BLL.SaleRecord record = new BLL.SaleRecord();
                int result = record.delete(Model.OverAllData.salerecordname);
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

        private void toolStripButton4_Click(object sender, EventArgs e) //点击查找按钮
        {
            string name = txtCheck.Text.Trim();
            BLL.SaleRecord record = new BLL.SaleRecord();
            DataTable dt = record.saleinfo(name);
            dataGridView1.DataSource = dt;
        }
    }
}
