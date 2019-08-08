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
    public partial class FrmVIewOreder : Form
    {
        public FrmVIewOreder()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void FrmVIewOreder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'belajar1DataSet5.headerorder' table. You can move, or remove it, as needed.
            this.headerorderTableAdapter.Fill(this.belajar1DataSet5.headerorder);
            filterTable();
        }
        private void loadTable()
        {
            // TODO: This line of code loads data into the 'belajar1DataSet4.detailorder' table. You can move, or remove it, as needed.
            this.detailorderTableAdapter.Fill(this.belajar1DataSet4.detailorder);
        }
        private void filterTable()
        {
            loadTable();
            orderidtooltip.Text = comboID.Text;
            try
            {
                this.detailorderTableAdapter.FillBy2(this.belajar1DataSet4.detailorder, ((int)(System.Convert.ChangeType(orderidtooltip.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboID.Text != "" )
            {
                filterTable();
            }            
        }

        private void FillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private static string progress;
        private static int detaiID;
        ComboBox combo;
        private void DataGridOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridOrder.CurrentRow;
            progress = rows.Cells[5].Value.ToString();
            detaiID = Convert.ToInt32(rows.Cells[0].Value);
        }
        private void DataGridOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
             combo = e.Control as ComboBox;
             if(combo.Text != null)
            {
                combo.SelectionChangeCommitted -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectionChangeCommitted += combo_SelectedIndexChanged;
            }
        }

        private void combo_SelectedIndexChanged (object sender, EventArgs e)
        {
            string oldProgress = combo.Text;
            DialogResult comboRes = MessageBox.Show("Simpan Prosses", "yakin?", MessageBoxButtons.YesNo);
            if(comboRes == DialogResult.Yes)
            {
                detailorder detailOrder = new detailorder();
                detailOrder = db.detailorders.Single(id => id.detailid == detaiID);
                detailOrder.status = combo.Text;
                db.SubmitChanges();
                progress = combo.Text;
            }
            else {
                combo.Text = progress;
            }
        }

        private void DataGridOrder_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
     
        }
    }
}
