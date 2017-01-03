/*
 *创建人：琚建飞
 *创建时间：2016/12/10 19:22:55
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
    public partial class frmLoanRecord : Form
    {
        public frmLoanRecord()
        {
            InitializeComponent();
        }

        private void frmLoanRecord_Load(object sender, EventArgs e) //窗体加载事件
        {
            BindData();
        }

        private void BindData() //重新绑定数据
        {
            BLL.Equipment equipment = new BLL.Equipment();
            DataTable dt = equipment.ReturnLoanRecord();
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

        private void toolStripButton1_Click(object sender, EventArgs e) //点击添加记录按钮
        {
            frmAddLoanRecord f = new frmAddLoanRecord();
            f.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (mark3)
            {
                mark3 = !mark3; //取消选中
                frmModifyLoanRecord f = new frmModifyLoanRecord();
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
                Model.OverAllData.equipmentname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value); //获取某行的第一个单元格的数据传给全局变量sno
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e) //点击查找按钮
        {
            if (txtCheck.Text == "")
            {
                MessageBox.Show("请输入查询条件！", "温馨提示");
            }
            else
            {
                if (rabtSno.Checked)
                {
                    //根据借用人编号查询设备借用信息
                    int loanpno = Convert.ToInt32(txtCheck.Text.Trim());
                    //将name传给数据库进行查询并返回查询数据
                    BLL.Equipment equipment = new BLL.Equipment();
                    DataTable dt = equipment.SelectLoanInfoByno(loanpno);
                    if (dt.Rows.Count == 0) //判断返回值是否为空
                    {
                        MessageBox.Show("抱歉，没有此编号的员工，请确认后输入！", "温馨提示");
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                    }
                }
                else
                {
                    //根据设备名称查询设备借出信息
                    string name = txtCheck.Text.Trim();
                    //将name传给数据库进行查询并返回查询数据
                    BLL.Equipment loanrecord = new BLL.Equipment();
                    DataTable dt2 = loanrecord.SelectLoanInfoByName(name);
                    if (dt2.Rows.Count == 0) //判断返回值是否为空
                    {
                        MessageBox.Show("抱歉，没有此名称的设备，请确认后输入！", "温馨提示");
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
