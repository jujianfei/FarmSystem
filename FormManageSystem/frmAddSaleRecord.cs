/*
 *创建人：琚建飞
 *创建时间：2016/12/11 12:52:21
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
    public partial class frmAddSaleRecord : Form
    {
        public frmAddSaleRecord()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) //点击添加按钮
        {
            int nownum = Convert.ToInt32(txtNowNum.Text.Trim());
            Model.SaleRecord record = new Model.SaleRecord();
            record.name = txtName.Text.Trim();
            record.sale = txtSale.Text.Trim();
            record.save =Convert.ToString (nownum-Convert.ToInt32(txtSale.Text.Trim()));
            record.time = txtTime.Text.Trim();
            BLL.SaleRecord salerecord = new BLL.SaleRecord();
            int result = salerecord.AddSaleRecord(record);
            if (result > 0)
            {
                MessageBox.Show("添加信息成功！"+"卖出数量为："+record.sale+"库存量为："+record.save, "温馨提示");
                if (rabAnimal.Checked)
                {
                    //将库存量传入表中进行更新
                    BLL.Animal animal = new BLL.Animal();
                    animal.ModifyAnimalNumByName(record.name, record.save);
                    //添加配送信息
                    string no = txtTransportPerson.Text.Trim();
                    salerecord.transport(record.name,no);
                }
            }
            else
            {
                MessageBox.Show("添加信息失败，请联系管理员！", "温馨提示");
            }
        }

        private void txtCheck_Click(object sender, EventArgs e) //产看现有量
        {
            string name = txtName.Text.Trim();
            if (rabAnimal.Checked) //查找Animal表
            {
                BLL.Animal animal = new BLL.Animal();
                DataTable dt = animal.SelectAnimalByName(name);
                txtNowNum.Text = dt.Rows[0][1].ToString();
            }
            else  //查找Crops表
            {
                BLL.Crops crop = new BLL.Crops();
                DataTable dt = crop.SelectCropByName(name);
                txtNowNum.Text=dt.Rows[0][1].ToString();
            }
            txtNowNum.Visible = true;
            
        }

        private void txtSave_Enter(object sender, EventArgs e) 
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNowNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
