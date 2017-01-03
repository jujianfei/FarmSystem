/*
 *创建人：琚建飞
 *创建时间：2016/12/11 18:35:58
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
    public partial class frmModifySaleRecord : Form
    {
        public frmModifySaleRecord()
        {
            InitializeComponent();
        }

        private void ModifySaleRecord_Load(object sender, EventArgs e) //窗体加载事件
        {
            string name = Model.OverAllData.salerecordname;
            BLL.SaleRecord record = new BLL.SaleRecord();
            DataTable dt = record.saleinfo(name);
            txtName.Text=dt.Rows[0][1].ToString();
            txtSale.Text = dt.Rows[0][2].ToString();
            txtNowNum.Text=dt.Rows[0][3].ToString();
            txtTime.Text = dt.Rows[0][4].ToString();
        }

        private void btnOk_Click(object sender, EventArgs e) //点击确定按钮
        {
            Model.SaleRecord record = new Model.SaleRecord();
            record.name= txtName.Text.Trim(); //获取产品名
            record.sale = txtSale.Text.Trim();
            record.save = txtNowNum.Text.Trim();
            record.time = txtTime.Text.Trim();
            BLL.SaleRecord sale = new BLL.SaleRecord();
            int result = sale.modifyinfo(record);
            if (result > 0)
            {
                MessageBox.Show("信息修改成功！", "温馨提示");
            }
            else
            {
                MessageBox.Show("信息修改失败，请联系管理员！", "温馨提示");
            }
        }
    }
}
