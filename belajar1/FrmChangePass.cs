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
    public partial class FrmChangePass : Form
    {
        public FrmChangePass()
        {
            InitializeComponent();
        }
        private void load()
        {
            txtnewpassword.Text = null;
            txtoldpassword.Text = null;
            txtxconfirmpassword.Text = null;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (txtnewpassword.Text == "" || txtoldpassword.Text == "" || txtxconfirmpassword.Text == "")
            {
                MessageBox.Show("password must be field");
            }
            else if (txtnewpassword.Text == txtxconfirmpassword.Text)
            {
                msemployee employee = new msemployee();
                employee = db.msemployees.Single(x => x.employeeid == Form1.ID);
                if(employee.password == txtoldpassword.Text)
                {
                    employee.password = txtnewpassword.Text;
                    db.SubmitChanges();
                    load();
                    MessageBox.Show("Success changing password");
                }
                else
                {
                    MessageBox.Show("Wrong old password");
                }
            }
            else
            {
                MessageBox.Show("Check your confirm password");
            }
        }
    }
}
