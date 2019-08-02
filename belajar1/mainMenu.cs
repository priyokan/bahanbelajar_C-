using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belajar1
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lblName.Text = Form1.name;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void BtnManageEmploye_Click(object sender, EventArgs e)
        {
            FrmManageEmploye manageEmploye = new FrmManageEmploye();
            manageEmploye.Show();
        }

        private void BtnManageMenu_Click(object sender, EventArgs e)
        {
            FrmManageMenu manageMenu = new FrmManageMenu();
            manageMenu.Show();
        }

        private void BtnManageMember_Click(object sender, EventArgs e)
        {
            FrmManageMember manageMember = new FrmManageMember();
            manageMember.Show();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePass changepassword = new FrmChangePass();
            changepassword.Show();
        }
    }
}
