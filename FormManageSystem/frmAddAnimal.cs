/*
 *创建人：琚建飞
 *创建时间：2016/12/10 17:06:15
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
    public partial class frmAddAnimal : Form
    {
        public frmAddAnimal()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) //单击添加按钮
        {
            Model.Animal animal = new Model.Animal();
            animal.name = txtName.Text.Trim();
            animal.sum = txtSum.Text.Trim();
            animal.mno = txtMno.Text.Trim();
            BLL.Animal add = new BLL.Animal();
            int result = add.AddAnimal(animal);
            if (result > 0)
            {
                MessageBox.Show("添加信息成功！", "温馨提示");
            }
            else
            {
                MessageBox.Show("添加信息失败，请联系管理员！","温馨提示");
            }
        }
    }
}
