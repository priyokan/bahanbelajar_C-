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
    public partial class FrmManageEmploye : Form
    {
        public FrmManageEmploye()
        {
            InitializeComponent();
        }
        private void load()
        {
            // TODO: This line of code loads data into the 'belajar1DataSet.msemployee' table. You can move, or remove it, as needed.
            this.msemployeeTableAdapter.Fill(this.belajar1DataSet.msemployee);
            txtid.Text = null;
            txtname.Text = null;
            txtemail.Text = null;
            txtpassword.Text = null;
            txtHandphone.Text = null;
            comboPosition.Text = null;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void FrmManageEmploye_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            msemployee employee = new msemployee();
            employee.name = txtname.Text;
            employee.email = txtemail.Text;
            employee.password = txtpassword.Text;
            employee.hanphone = txtHandphone.Text;
            employee.position = comboPosition.Text;
            db.msemployees.InsertOnSubmit(employee);
            db.SubmitChanges();
            load();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            msemployee employee = new msemployee();
            employee = db.msemployees.Single(x => x.employeeid == Convert.ToInt32(txtid.Text));
            employee.name = txtname.Text;
            employee.email = txtemail.Text;
            employee.password = txtpassword.Text;
            employee.hanphone = txtHandphone.Text;
            employee.position = comboPosition.Text;
            db.SubmitChanges();
            load();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            msemployee employee = new msemployee();
            employee = db.msemployees.Single(x => x.employeeid == Convert.ToInt32(txtid.Text));
            db.msemployees.DeleteOnSubmit(employee);
            db.SubmitChanges();
            load();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = this.dataGridView1.CurrentRow;
            txtid.Text = rows.Cells[0].Value.ToString();
            txtname.Text = rows.Cells[1].Value.ToString();
            txtemail.Text = rows.Cells[2].Value.ToString();
            txtpassword.Text = rows.Cells[3].Value.ToString();
            txtHandphone.Text = rows.Cells[4].Value.ToString();
            comboPosition.Text = rows.Cells[5].Value.ToString();
        }
    }
}
