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
    public partial class chefMenu : Form
    {
        public chefMenu()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ChefMenu_Load(object sender, EventArgs e)
        {
            lblName.Text = Form1.name;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void BtnViewOrder_Click(object sender, EventArgs e)
        {
            FrmVIewOreder viewOrder = new FrmVIewOreder();
            viewOrder.Show();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePass changePass = new FrmChangePass();
            changePass.Show();
        }
    }
}
