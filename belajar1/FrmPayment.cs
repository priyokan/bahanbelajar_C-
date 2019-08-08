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
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void filterTable()
        {
            try
            {
                this.detailorderTableAdapter.FillBy(this.belajar1DataSet5.detailorder, ((int)(System.Convert.ChangeType(orderIdToolStrip.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void loadData()
        {
            // TODO: This line of code loads data into the 'belajar1DataSet5.detailorder' table. You can move, or remove it, as needed.
            this.detailorderTableAdapter.Fill(this.belajar1DataSet5.detailorder);
            try
            {
                this.headerorderTableAdapter.FillBy1(this.belajar1DataSet5.headerorder, paymentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void loadTable()
        {
            loadData();
            txtBankName.Text = null;
            txtCardNumber.Text = null;
            txtPaymentType.Text = null;
            orderIdToolStrip.Text = comboOrderID.Text;
            filterTable();
            int allPrice = 0;
            for (int i = 0; i < dataGridOrder.RowCount ; i++)
            {
                int menuId = Convert.ToInt32(dataGridOrder.Rows[i].Cells[6].Value);
                msmenu menu = new msmenu();
                menu = db.msmenus.Single(id => id.menuid == menuId);
                string namaMenu = menu.name;
                int price = menu.price;
                dataGridOrder.Rows[i].Cells[0].Value = namaMenu ;
                dataGridOrder.Rows[i].Cells[2].Value = price;

                int totalPrice = Convert.ToInt32(dataGridOrder.Rows[i].Cells[3].Value);
                allPrice += totalPrice;
                lblTotal.Text = allPrice.ToString();
            }
            headerorder headerOrder = new headerorder();
            headerOrder = db.headerorders.Single(id => id.orderid == Convert.ToInt32(comboOrderID.Text));
            if (headerOrder.payment == "null")
            {
                btnSave.Enabled = true;
                txtBankName.Enabled = true;
                txtCardNumber.Enabled = true;
                txtPaymentType.Enabled = true;
                txtPaymentType.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                txtBankName.Enabled = false;
                txtCardNumber.Enabled = false;
                txtPaymentType.Enabled = false;
            }
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'belajar1DataSet5.headerorder' table. You can move, or remove it, as needed.
            this.headerorderTableAdapter.Fill(this.belajar1DataSet5.headerorder);
            loadTable();
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {           

        }

        private void ComboOrderID_TextChanged(object sender, EventArgs e)
        {
            if (comboOrderID.Text != "")
            {
                loadTable();
            }
         
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            headerorder headerOrder = new headerorder();
            headerOrder = db.headerorders.Single(id => id.orderid == Convert.ToInt32(comboOrderID.Text));
            headerOrder.payment = txtPaymentType.Text;
            headerOrder.cardnumber = txtCardNumber.Text;
            headerOrder.bank = txtBankName.Text;
            db.SubmitChanges();
            MessageBox.Show("transaksi berhasil");
            loadTable();
        }

        private void FillByToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
