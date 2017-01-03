/*
 *创建人：琚建飞
 *创建时间：2016/12/12 8:09:23
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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e) //窗体加载事件
        {
            BLL.Staff department = new BLL.Staff();
            DataTable dt = department.departmentinfo();
            dataGridView1.DataSource = dt;
        }
    }
}
