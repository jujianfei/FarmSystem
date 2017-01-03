using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormManageSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) //窗体启动时加载界面行政部
        {
            if (Model.OverAllData.level == "CEO")
            {
                panel5.Show();
                panel5.Dock = DockStyle.Fill;
                panel6.Hide();
                panel7.Hide();
                panel10.Hide();
                panel11.Hide();
            }
            else if (Model.OverAllData.level == "人事部长")
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button8.Enabled = false;
                button17.Enabled = false;
                panel5.Show();
                panel5.Dock = DockStyle.Fill;
                panel6.Hide();
                panel7.Hide();
                panel10.Hide();
                panel11.Hide();
            }
            else if (Model.OverAllData.level == "设备部长")
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                panel10.Show();
                panel10.Dock = DockStyle.Fill;
                panel6.Hide();
                panel7.Hide();
                panel5.Hide();
                panel11.Hide();
            }
            else if (Model.OverAllData.level == "生产部长")
            {
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                button17.Enabled = false;
                panel6.Show();
                panel6.Dock = DockStyle.Fill;
                panel5.Hide();
                panel7.Hide();
                panel10.Hide();
                panel11.Hide();
            }
            else if (Model.OverAllData.level == "销售部长")
            {
                button5.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                button17.Enabled = false;
                panel7.Show();
                panel7.Dock = DockStyle.Fill;
                panel6.Hide();
                panel5.Hide();
                panel10.Hide();
                panel11.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e) //点击员工管理
        {
            frmPersonDepartement f = new frmPersonDepartement();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e) //人事部
        {
            panel5.Show();
            panel5.Dock = DockStyle.Fill;
            panel6.Hide();
            panel7.Hide();
            panel10.Hide();
            panel11.Hide();
        }

        private void button5_Click(object sender, EventArgs e) //生产部
        {
            panel6.Show();
            panel6.Dock = DockStyle.Fill;
            panel5.Hide();
            panel7.Hide();
            panel10.Hide();
            panel11.Hide();
        }

        private void button4_Click(object sender, EventArgs e) //销售部
        {
            panel7.Show();
            panel7.Dock = DockStyle.Fill;
            panel6.Hide();
            panel5.Hide();
            panel10.Hide();
            panel11.Hide();
        }

        private void button13_Click(object sender, EventArgs e) //退出系统按钮
        {
            if (DialogResult.Yes == MessageBox.Show("是否退出系统？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Dispose();
                Environment.Exit(0); //应用程序强制退出。相对于Application.Exit()方法，此方法更加暴力
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) //点击右上角红叉退出系统
        {
            if (DialogResult.Yes == MessageBox.Show("是否退出系统？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Dispose();
                Environment.Exit(0); //应用程序强制退出。相对于Application.Exit()方法，此方法更加暴力
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button8_Click(object sender, EventArgs e) //用户管理页面
        {
            panel11.Show();
            panel11.Dock = DockStyle.Fill;
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel10.Hide();
        }

        private void button15_Click(object sender, EventArgs e) //点击设备管理按钮
        {
            frmEquipment f = new frmEquipment();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //部门号
        {
            frmDepartment f = new frmDepartment();
            f.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e) //点击种植按钮
        {
            frmCrops f = new frmCrops();
            f.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e) //点击设备部
        {
            panel10.Show();
            panel10.Dock = DockStyle.Fill;
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel11.Hide();
        }

        private void button19_Click(object sender, EventArgs e) //点击添加用户按钮
        {
            frmAddUser f = new frmAddUser();
            f.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e) //点击修改密码
        {
            frmModifyUserPassword f = new frmModifyUserPassword();
            f.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)//点击牲畜管理
        {
            frmAnimal f = new frmAnimal();
            f.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e) //点击借出记录表
        {
            frmLoanRecord f = new frmLoanRecord();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e) //点击销售按钮
        {
            frmSaleManage f = new frmSaleManage();
            f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e) //点击配送管理
        {
            frmTransport f = new frmTransport();
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "宝石蓝")
            {
                if (skinEngine1.Active == false)//关闭
                {
                    skinEngine1.Active = true;//激活
                    this.skinEngine1.SkinFile = "MP10.ssk";
                }
                else
                {
                    this.skinEngine1.SkinFile = "MP10.ssk";
                }
            }
            else if (comboBox1.Text == "墨黑")
            {
                if (skinEngine1.Active == false)//关闭
                {
                    skinEngine1.Active = true;//激活
                    this.skinEngine1.SkinFile = "SteelBlack.ssk";
                }
                else
                {
                    this.skinEngine1.SkinFile = "SteelBlack.ssk";
                }
            }
            else
            {
                skinEngine1.Active = false;//关闭
            }
        }
    }
}
