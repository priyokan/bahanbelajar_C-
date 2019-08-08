using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belajar1
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        string[] month = { "January", "February", "Mart", "April", "Mei", "Juny", "July", "Agustus", "September", "October", "Novermber", "December" };
        
        private void filterDate()
        {
            try
            {
                this.headerorderTableAdapter.FillBy(this.belajar1DataSet6.headerorder, dateToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'belajar1DataSet6.headerorder' table. You can move, or remove it, as needed.
            this.headerorderTableAdapter.Fill(this.belajar1DataSet6.headerorder);
            string query = @"SELECT * FROM dbo.detailorder WHERE orderid= 2";
            SqlConnection sqlcon = new SqlConnection(@"Data Source = localhost ; Initial Catalog = belajar1 ; Integrated Security = true");
            SqlDataAdapter sda = new SqlDataAdapter(query,sqlcon);
            DataTable dttbl = new DataTable();
            sda.Fill(dttbl);


            btnGenerate.Enabled = false;

            for (int i = 0; i < month.Length; i++)
            {
                comboFrom.Items.Add(month[i]);
            }
            comboTo.Enabled = false;
        }

        private void ComboFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }
        int numberMonth;
        int numberMonthTo;
        private void ComboFrom_TextChanged(object sender, EventArgs e)
        {
            string getIndex = comboFrom.Text;
            numberMonth = Array.IndexOf(month, getIndex)+1;
            comboTo.Enabled = true;
            comboTo.Items.Clear();
            for (int i = numberMonth; i < month.Length; i++)
            {
                comboTo.Items.Add(month[i]);
            }
        }


        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            for (int i = numberMonth-1; i < numberMonthTo ; i++)
             {
                string dateIndex = Convert.ToString(i+1);
                if (dateIndex.Length == 1)
                {
                    dateToolStripTextBox.Text = "2019-0"+dateIndex;
                }
                else if(dateIndex.Length  == 2)
                {
                    dateToolStripTextBox.Text = "2019-"+ dateIndex;
                }
                filterDate();
                int total = 0;
                for (int ind = 0; ind < bindHeadOrder.RowCount; ind++)
                {
                    total += Convert.ToInt32(bindHeadOrder.Rows[ind].Cells[7].Value);
                }
                dataGrid.Rows.Add(month[i], total); 
             }
        }

        private void ComboTo_TextChanged(object sender, EventArgs e)
        {
            string getIndex = comboTo.Text;
            numberMonthTo = Array.IndexOf(month, getIndex) + 1;
            btnGenerate.Enabled = true;
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }
    }
}
