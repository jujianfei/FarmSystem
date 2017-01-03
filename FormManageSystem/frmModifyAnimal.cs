/*
 *创建人：琚建飞
 *创建时间：2016/12/10 16:34:43
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
    public partial class frmModifyAnimal : Form
    {
        public frmModifyAnimal()
        {
            InitializeComponent();
        }

        private void frmModifyAnimal_Load(object sender, EventArgs e) //窗体加载事件
        {
            string animalname = Model.OverAllData.animalname;
            BLL.Animal animal = new BLL.Animal();
            DataTable dt = animal.SelectAnimalByName(animalname);
            txtName.Text = dt.Rows[0][0].ToString();
            txtSum.Text = dt.Rows[0][1].ToString();
            txtMno.Text = dt.Rows[0][2].ToString();
        }

        private void btnOk_Click(object sender, EventArgs e) //点击确定按钮
        {
            Model.Animal animal = new Model.Animal(); //声明一个牲畜实体
            //获取界面的信息，并传给实体
            animal.name = txtName.Text.Trim();
            animal.sum = txtSum.Text.Trim();
            animal.mno = txtMno.Text.Trim();
            //将实体传给数据库
            BLL.Animal modify = new BLL.Animal();
            int result = modify.ModifyAnimalinfo(animal);
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
