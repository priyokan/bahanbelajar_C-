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
    public partial class cashierMenu : Form
    {
        public cashierMenu()
        {
            InitializeComponent();
        }

        private void CashierMenu_Load(object sender, EventArgs e)
        {
            lblName.Text = Form1.name;
        }


        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.Show();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            FrmPayment payment = new FrmPayment();
            payment.Show();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePass changePassword = new FrmChangePass();
            changePassword.Show();
        }
    }
}
