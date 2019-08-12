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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        private static int menuId = 0;
        private static int menuPrice = 0;
        private static int orderId = 0;
        private static int detailId;

        private void actSearch()
        {
            try
            {
                this.detailorderTableAdapter.FillBy(this.belajar1DataSet4.detailorder, ((int)(System.Convert.ChangeType(orderIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void loadTable()
        {
            // TODO: This line of code loads data into the 'belajar1DataSet2.msmenu' table. You can move, or remove it, as needed.
            this.msmenuTableAdapter.Fill(this.belajar1DataSet2.msmenu);
            // TODO: This line of code loads data into the 'belajar1DataSet3.msmember' table. You can move, or remove it, as needed.
            this.msmemberTableAdapter.Fill(this.belajar1DataSet3.msmember);
            // TODO: This line of code loads data into the 'belajar1DataSet4.detailorder' table. You can move, or remove it, as needed.
            this.detailorderTableAdapter.Fill(this.belajar1DataSet4.detailorder);

            txtname.Text = null;
            txtprice.Text = null;
            txtqty.Value = 1;
            pictReview.ImageLocation = null;
            int allPrice = 0;

            orderIDToolStripTextBox.Text = orderId.ToString();
            actSearch();

            for (int i = 0; i < dataGridOrder.RowCount; i++)
            {
                int menuId = Convert.ToInt32(dataGridOrder.Rows[i].Cells[2].Value);
                msmenu menu = new msmenu();
                menu = db.msmenus.Single(id => id.menuid == menuId);
                string namaMenu = menu.name;
                int price = menu.price;
                dataGridOrder.Rows[i].Cells[3].Value = namaMenu;
                dataGridOrder.Rows[i].Cells[5].Value = price;

                int totalPrice = Convert.ToInt32(dataGridOrder.Rows[i].Cells[6].Value);
                allPrice += totalPrice;
                lblTotal.Text = allPrice.ToString();
            }
        }
        private void FrmOrder_Load(object sender, EventArgs e)
        {
            loadTable();
            dataGridMenu.Enabled = false;
            txtname.Enabled = false;
            txtprice.Enabled = false;
            txtqty.Enabled = false;
            dataGridOrder.Enabled = false;
            btnAdd.Enabled = false;
            btndelete.Enabled = false;
            btnOrder.Enabled = false;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            detailorder detailOrder = new detailorder();
            detailOrder.orderid = orderId;
            detailOrder.menuid = Convert.ToInt32(menuId);
            detailOrder.price = calc(Convert.ToInt32(txtqty.Value));
            detailOrder.qty = Convert.ToInt32(txtqty.Value);
            detailOrder.status = "ordered";
            db.detailorders.InsertOnSubmit(detailOrder);

            db.SubmitChanges();
            loadTable();
            btnOrder.Enabled = true;
            btndelete.Enabled = true;
        }

        private static int calc(int qty)
        {
            int totalPrice = menuPrice * Convert.ToInt32(qty);
            return totalPrice;
        }
        private void Combomember_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DialogResult dialogres = MessageBox.Show("are you sure?", "", MessageBoxButtons.YesNo);
            if (dialogres == DialogResult.Yes)
            {
                DateTimePicker date = new DateTimePicker();
                headerorder headerOrder = new headerorder();
                headerOrder.employeeid = Form1.ID;
                headerOrder.memberid = Convert.ToInt32(combomember.Text);
                headerOrder.date = date.Value;
                headerOrder.payment = "null";
                headerOrder.cardnumber = "null";
                headerOrder.bank = "null";
                headerOrder.totalPayment = 0    ;
                db.headerorders.InsertOnSubmit(headerOrder);
                db.SubmitChanges();
                combomember.Enabled = false;
                dataGridMenu.Enabled = true;
                txtname.Enabled = true;
                txtprice.Enabled = true;
                txtqty.Enabled = true;
                dataGridOrder.Enabled = true;
                btnAdd.Enabled = true;

                orderId = db.headerorders.Max(x => x.orderid);
            }
            else if(dialogres == DialogResult.No)
            {
                combomember.Text = "1";
            }
        }

        private void DataGridMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridMenu.CurrentRow;
            menuId = Convert.ToInt32(row.Cells[0].Value);
            txtname.Text = row.Cells[1].Value.ToString();
            menuPrice = Convert.ToInt32(row.Cells[2].Value);
            txtprice.Text = row.Cells[2].Value.ToString();
            pictReview.ImageLocation = row.Cells[3].Value.ToString();
        }

        private void Txtqty_Click(object sender, EventArgs e)
        {
            int Qty = Convert.ToInt32(txtqty.Value);
            txtprice.Text =  calc(Qty).ToString();
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            actSearch();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            detailorder detailOrder = new detailorder();
            detailOrder = db.detailorders.Single(id => id.detailid == detailId);
            db.detailorders.DeleteOnSubmit(detailOrder);
            db.SubmitChanges();

            loadTable();
            txtqty.Enabled = true;
        }

        private void DataGridOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridOrder.CurrentRow;
            detailId = Convert.ToInt32(rows.Cells[0].Value);
            int menuID = Convert.ToInt32(rows.Cells[2].Value);
            txtqty.Value = Convert.ToInt32(rows.Cells[4].Value);
            txtprice.Text = rows.Cells[5].Value.ToString();

            msmenu menu = new msmenu();
            menu = db.msmenus.Single(x => x.menuid == menuID);
            pictReview.ImageLocation = menu.photo;
            txtname.Text = menu.name;
            txtqty.Enabled = false;
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            headerorder headerOrder = new headerorder();
            headerOrder = db.headerorders.Single(id => id.orderid == orderId);
            headerOrder.totalPayment = Convert.ToInt32(lblTotal.Text);
            db.SubmitChanges();

            MessageBox.Show("transaksi berhasil");

            dataGridMenu.Enabled = false;
            txtname.Enabled = false;
            txtprice.Enabled = false;
            txtqty.Enabled = false;
            dataGridOrder.Enabled = false;
            btnAdd.Enabled = false;
            btndelete.Enabled = false;
            btnOrder.Enabled = false;
            combomember.Enabled = true;
            lblTotal.Text = "0";

            menuId = 0;
            menuPrice = 0;
            orderId = 0;
            detailId = 0;
            loadTable();
        }
    }
}
