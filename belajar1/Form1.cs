﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        public static int ID = 0;
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
                ID = login.employeeid;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Email invalid");
            }
        }
    }
}
