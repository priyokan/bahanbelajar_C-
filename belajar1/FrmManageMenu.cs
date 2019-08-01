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
    public partial class FrmManageMenu : Form
    {
        public FrmManageMenu()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void load()
        {
            // TODO: This line of code loads data into the 'belajar1DataSet2.msmenu' table. You can move, or remove it, as needed.
            this.msmenuTableAdapter.Fill(this.belajar1DataSet2.msmenu);
            txtid.Text = null;
            txtname.Text = null;
            txtprice.Text = null;
            txtphoto.Text = null;
            pictview.ImageLocation = null;
        }

        private void FrmManageMenu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtid.Text = row.Cells[0].Value.ToString();
            txtname.Text = row.Cells[1].Value.ToString();
            txtprice.Text = row.Cells[2].Value.ToString();
            txtphoto.Text = row.Cells[3].Value.ToString();
            pictview.ImageLocation = row.Cells[3].Value.ToString();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btninsert_Click(object sender, EventArgs e)
        {
            msmenu menu = new msmenu();
            menu.name = txtname.Text;
            menu.price = Convert.ToInt32(txtprice.Text);
            menu.photo = txtphoto.Text.ToString();
            db.msmenus.InsertOnSubmit(menu);
            db.SubmitChanges();
            load();
        }

        private void Btnselectphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files(*.jpg,*.png,*.jpeg)|*.jpg;*.png;*.jpeg;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictview.ImageLocation = openFile.FileName;
                txtphoto.Text = openFile.FileName;
            }
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            msmenu menu = new msmenu();
            menu = db.msmenus.Single(x => x.menuid == Convert.ToInt32(txtid.Text));
            menu.name = txtname.Text;
            menu.price = Convert.ToInt32(txtprice.Text);
            menu.photo = txtphoto.Text.ToString();
            db.SubmitChanges();
            load();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            msmenu menu = new msmenu();
            menu = db.msmenus.Single(x => x.menuid == Convert.ToInt32(txtid.Text));
            db.msmenus.DeleteOnSubmit(menu);
            db.SubmitChanges();
            load();
        }
    }
}
