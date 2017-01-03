using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FormManageSystem
{
    public partial class frmPersonDepartement : Form
    {
        public frmPersonDepartement()
        {
            InitializeComponent();
        }

        private void frmPersonDepartement_Load(object sender, EventArgs e) //窗体显示时加载员工信息表
        {
            BindData();
        }

        private void BindData()     //重新加载员工信息表
        {
            BLL.Staff staffinfo = new BLL.Staff();
            DataTable dt = staffinfo.StaffInfo();
            dataGridView1.DataSource = dt;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)  //添加按钮
        {
            frmAddStaff f = new frmAddStaff();
            f.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e) //刷新按钮
        {
            BindData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //单击修改按钮
        {
            if (mark3)
            {
                mark3 = !mark3; //取消选中
                frmUpdateStaffinfo uf = new frmUpdateStaffinfo();
                uf.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选中一条记录再进行操作！");
            }
        }

        bool mark3 = false;
        /// <summary>
        ///  选中dataGridView的某行的某个单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //单击单元格任意位置触发此事件
        {
            if (e.RowIndex > -1)      //单击某一行
            {
                mark3 = true;
                Model.OverAllData.sno = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value); //获取某行的第一个单元格的数据传给全局变量sno
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //单击删除按钮
        {
            if (mark3)
            {
                mark3 = !mark3;//取消选中
                BLL.Staff deletestaff = new BLL.Staff();
                int result = deletestaff.DeleteStaffInfo(Model.OverAllData.sno);
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

        private void toolStripButton4_Click(object sender, EventArgs e) //查询按钮
        {
            if (txtCheck.Text == "")
            {
                MessageBox.Show("请输入查询条件！", "温馨提示");
            }
            else
            {
                if (rabtSno.Checked)
                {
                    //根据编号查询员工信息
                    string sno = txtCheck.Text.Trim();
                    BLL.Staff staffsno = new BLL.Staff();
                    DataTable dt = staffsno.SelectStaffInfo(sno);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    //根据姓名查询员工信息
                    string name = txtCheck.Text.Trim();
                    BLL.Staff staffname = new BLL.Staff();
                    DataTable dt = staffname.SelectStaffNameInfo(name);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)//关闭人事部门信息窗体按钮
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e) //导出数据按钮
        {
            string fileName = "";
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
            //写入标题             
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            { worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText; }
            //写入数值
            for (int r = 0; r < dataGridView1.Rows.Count; r++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dataGridView1.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            MessageBox.Show(fileName + "资料保存成功", "提示", MessageBoxButtons.OK);
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 
                }
                catch (Exception ex)
                {//fileSaved = false;                      
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁           
        }
    }
}

