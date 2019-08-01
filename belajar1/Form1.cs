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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        public static string name ="";
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var login = (from a in db.msemployees
                         where a.email == txtEmail.Text &&
                         a.password == txtPassword.Text
                         select a).FirstOrDefault();
            if (login!=null)
            {
                name = login.name;
                if (login.position == "admin")
                {
                    mainMenu main = new mainMenu();
                    main.Show();
                    this.Hide();
                }
                else if (login.position == "chef")
                {
                    chefMenu chefMenu = new chefMenu();
                    chefMenu.Show();
                    this.Hide();
                }
                else if (login.position == "cashier")
                {
                    cashierMenu cashierMenu = new cashierMenu();
                    cashierMenu.Show();
                    this.Hide();
                }
            }
            else if (txtEmail.Text == "" || txtPassword.Text=="")
            {
                MessageBox.Show("email dan password harus di isi");
            }
            else
            {
                MessageBox.Show("email atau password salah");
            }
        }
    }
}
