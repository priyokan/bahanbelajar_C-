namespace belajar1
{
    partial class FrmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belajar1DataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belajar1DataSet5 = new belajar1.belajar1DataSet5();
            this.label2 = new System.Windows.Forms.Label();
            this.comboOrderID = new System.Windows.Forms.ComboBox();
            this.headerorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPaymentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.headerorderTableAdapter = new belajar1.belajar1DataSet5TableAdapters.headerorderTableAdapter();
            this.detailorderTableAdapter = new belajar1.belajar1DataSet5TableAdapters.detailorderTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.orderIdToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.orderIdToolStrip = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.paymentToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paymentToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerorderBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Payment";
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AutoGenerateColumns = false;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menu,
            this.qtyDataGridViewTextBoxColumn,
            this.Price,
            this.priceDataGridViewTextBoxColumn,
            this.detailidDataGridViewTextBoxColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.menuidDataGridViewTextBoxColumn});
            this.dataGridOrder.DataSource = this.detailorderBindingSource;
            this.dataGridOrder.Location = new System.Drawing.Point(12, 71);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(555, 236);
            this.dataGridOrder.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Menu.HeaderText = "Menu";
            this.Menu.Name = "Menu";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 48;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 56;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Total";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 56;
            // 
            // detailidDataGridViewTextBoxColumn
            // 
            this.detailidDataGridViewTextBoxColumn.DataPropertyName = "detailid";
            this.detailidDataGridViewTextBoxColumn.HeaderText = "detailid";
            this.detailidDataGridViewTextBoxColumn.Name = "detailidDataGridViewTextBoxColumn";
            this.detailidDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailidDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "orderid";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "orderid";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.Visible = false;
            // 
            // menuidDataGridViewTextBoxColumn
            // 
            this.menuidDataGridViewTextBoxColumn.DataPropertyName = "menuid";
            this.menuidDataGridViewTextBoxColumn.HeaderText = "menuid";
            this.menuidDataGridViewTextBoxColumn.Name = "menuidDataGridViewTextBoxColumn";
            this.menuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // detailorderBindingSource
            // 
            this.detailorderBindingSource.DataMember = "detailorder";
            this.detailorderBindingSource.DataSource = this.belajar1DataSet5BindingSource;
            // 
            // belajar1DataSet5BindingSource
            // 
            this.belajar1DataSet5BindingSource.DataSource = this.belajar1DataSet5;
            this.belajar1DataSet5BindingSource.Position = 0;
            // 
            // belajar1DataSet5
            // 
            this.belajar1DataSet5.DataSetName = "belajar1DataSet5";
            this.belajar1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order ID";
            // 
            // comboOrderID
            // 
            this.comboOrderID.DataSource = this.headerorderBindingSource;
            this.comboOrderID.DisplayMember = "orderid";
            this.comboOrderID.FormattingEnabled = true;
            this.comboOrderID.Location = new System.Drawing.Point(223, 44);
            this.comboOrderID.Name = "comboOrderID";
            this.comboOrderID.Size = new System.Drawing.Size(156, 21);
            this.comboOrderID.TabIndex = 3;
            this.comboOrderID.ValueMember = "orderid";
            this.comboOrderID.TextChanged += new System.EventHandler(this.ComboOrderID_TextChanged);
            // 
            // headerorderBindingSource
            // 
            this.headerorderBindingSource.DataMember = "headerorder";
            this.headerorderBindingSource.DataSource = this.belajar1DataSet5;
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.FormattingEnabled = true;
            this.txtPaymentType.Items.AddRange(new object[] {
            "Credit card",
            "ATM card",
            "check",
            "Debit Card",
            "E-money"});
            this.txtPaymentType.Location = new System.Drawing.Point(241, 313);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(156, 21);
            this.txtPaymentType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Card Number";
            // 
            // txtBankName
            // 
            this.txtBankName.FormattingEnabled = true;
            this.txtBankName.Items.AddRange(new object[] {
            "BNI",
            "BRI",
            "BCA",
            "Mandiri",
            "OVO"});
            this.txtBankName.Location = new System.Drawing.Point(241, 367);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(156, 21);
            this.txtBankName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bank Name";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(241, 340);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(156, 20);
            this.txtCardNumber.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // headerorderTableAdapter
            // 
            this.headerorderTableAdapter.ClearBeforeFill = true;
            // 
            // detailorderTableAdapter
            // 
            this.detailorderTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderIdToolStripLabel,
            this.orderIdToolStrip,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(776, 25);
            this.fillByToolStrip.TabIndex = 12;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // orderIdToolStripLabel
            // 
            this.orderIdToolStripLabel.Name = "orderIdToolStripLabel";
            this.orderIdToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.orderIdToolStripLabel.Text = "orderId:";
            // 
            // orderIdToolStrip
            // 
            this.orderIdToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.orderIdToolStrip.Name = "orderIdToolStrip";
            this.orderIdToolStrip.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total: Rp.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(472, 317);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "0";
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentToolStripLabel,
            this.paymentToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(587, 25);
            this.fillBy1ToolStrip.TabIndex = 15;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // paymentToolStripLabel
            // 
            this.paymentToolStripLabel.Name = "paymentToolStripLabel";
            this.paymentToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.paymentToolStripLabel.Text = "payment:";
            // 
            // paymentToolStripTextBox
            // 
            this.paymentToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paymentToolStripTextBox.Name = "paymentToolStripTextBox";
            this.paymentToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.paymentToolStripTextBox.Text = "null";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.FillBy1ToolStripButton_Click);
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 443);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.label1);
            this.Name = "FrmPayment";
            this.Text = "FrmPayment";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerorderBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboOrderID;
        private System.Windows.Forms.ComboBox txtPaymentType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtBankName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Button btnSave;
        private belajar1DataSet5 belajar1DataSet5;
        private System.Windows.Forms.BindingSource headerorderBindingSource;
        private belajar1DataSet5TableAdapters.headerorderTableAdapter headerorderTableAdapter;
        private System.Windows.Forms.BindingSource belajar1DataSet5BindingSource;
        private System.Windows.Forms.BindingSource detailorderBindingSource;
        private belajar1DataSet5TableAdapters.detailorderTableAdapter detailorderTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel orderIdToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox orderIdToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel paymentToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paymentToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}