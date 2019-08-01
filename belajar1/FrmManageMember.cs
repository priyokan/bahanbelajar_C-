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
    public partial class FrmManageMember : Form
    {
        public FrmManageMember()
        {
            InitializeComponent();
        }

        private void load()
        {
            // TODO: This line of code loads data into the 'belajar1DataSet3.msmember' table. You can move, or remove it, as needed.
            this.msmemberTableAdapter.Fill(this.belajar1DataSet3.msmember);
            txtid.Text = null;
            txtname.Text = null;
            txtemail.Text = null;
            txthandphone.Text = null;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void FrmManageMember_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btninsert_Click(object sender, EventArgs e)
        {
            msmember member = new msmember();
            member.name = txtname.Text;
            member.email = txtemail.Text;
            member.handphone = txthandphone.Text.ToString();
            member.joindate = dateTimePicker1.Value;
            db.msmembers.InsertOnSubmit(member);
            db.SubmitChanges();
            load();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtid.Text = row.Cells[0].Value.ToString();
            txtname.Text = row.Cells[1].Value.ToString();
            txtemail.Text = row.Cells[2].Value.ToString();
            txthandphone.Text = row.Cells[3].Value.ToString();
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            msmember member = new msmember();
            member = db.msmembers.Single(x => x.memberid == Convert.ToInt32(txtid.Text));
            member.name = txtname.Text;
            member.email = txtemail.Text;
            member.handphone = txthandphone.Text;
            db.SubmitChanges();
            load();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            msmember member = new msmember();
            member = db.msmembers.Single(x => x.memberid == Convert.ToInt32(txtid.Text));
            db.msmembers.DeleteOnSubmit(member);
            db.SubmitChanges();
            load();
        }

        private void Txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
