namespace belajar1
{
    partial class frmOrder
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
            this.dataGridMenu = new System.Windows.Forms.DataGridView();
            this.menuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belajar1DataSet2 = new belajar1.belajar1DataSet2();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.detailorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belajar1DataSet4 = new belajar1.belajar1DataSet4();
            this.pictReview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.detailorderTableAdapter = new belajar1.belajar1DataSet4TableAdapters.detailorderTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.combomember = new System.Windows.Forms.ComboBox();
            this.msmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belajar1DataSet3 = new belajar1.belajar1DataSet3();
            this.msmemberTableAdapter = new belajar1.belajar1DataSet3TableAdapters.msmemberTableAdapter();
            this.belajar1DataSet1 = new belajar1.belajar1DataSet1();
            this.msmenuTableAdapter = new belajar1.belajar1DataSet2TableAdapters.msmenuTableAdapter();
            this.txtqty = new System.Windows.Forms.NumericUpDown();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.orderIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.orderIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labelId = new System.Windows.Forms.ToolStripLabel();
            this.msmenuTableAdapter1 = new belajar1.belajar1DataSet1TableAdapters.msmenuTableAdapter();
            this.detailidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Form";
            // 
            // dataGridMenu
            // 
            this.dataGridMenu.AllowUserToAddRows = false;
            this.dataGridMenu.AllowUserToDeleteRows = false;
            this.dataGridMenu.AutoGenerateColumns = false;
            this.dataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dataGridMenu.DataSource = this.msmenuBindingSource;
            this.dataGridMenu.Location = new System.Drawing.Point(39, 77);
            this.dataGridMenu.Name = "dataGridMenu";
            this.dataGridMenu.ReadOnly = true;
            this.dataGridMenu.Size = new System.Drawing.Size(480, 177);
            this.dataGridMenu.TabIndex = 1;
            this.dataGridMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMenu_CellClick);
            // 
            // menuidDataGridViewTextBoxColumn
            // 
            this.menuidDataGridViewTextBoxColumn.DataPropertyName = "menuid";
            this.menuidDataGridViewTextBoxColumn.HeaderText = "menuid";
            this.menuidDataGridViewTextBoxColumn.Name = "menuidDataGridViewTextBoxColumn";
            this.menuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.ReadOnly = true;
            this.photoDataGridViewTextBoxColumn.Visible = false;
            // 
            // msmenuBindingSource
            // 
            this.msmenuBindingSource.DataMember = "msmenu";
            this.msmenuBindingSource.DataSource = this.belajar1DataSet2;
            // 
            // belajar1DataSet2
            // 
            this.belajar1DataSet2.DataSetName = "belajar1DataSet2";
            this.belajar1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToDeleteRows = false;
            this.dataGridOrder.AutoGenerateColumns = false;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailidDataGridViewTextBoxColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.menuidDataGridViewTextBoxColumn1,
            this.menu,
            this.qtyDataGridViewTextBoxColumn,
            this.price,
            this.priceDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridOrder.DataSource = this.detailorderBindingSource;
            this.dataGridOrder.Location = new System.Drawing.Point(39, 384);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.Size = new System.Drawing.Size(480, 166);
            this.dataGridOrder.TabIndex = 2;
            this.dataGridOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridOrder_CellClick);
            // 
            // detailorderBindingSource
            // 
            this.detailorderBindingSource.DataMember = "detailorder";
            this.detailorderBindingSource.DataSource = this.belajar1DataSet4;
            // 
            // belajar1DataSet4
            // 
            this.belajar1DataSet4.DataSetName = "belajar1DataSet4";
            this.belajar1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictReview
            // 
            this.pictReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictReview.Location = new System.Drawing.Point(39, 260);
            this.pictReview.Name = "pictReview";
            this.pictReview.Size = new System.Drawing.Size(192, 118);
            this.pictReview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictReview.TabIndex = 3;
            this.pictReview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menu Name";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Location = new System.Drawing.Point(335, 269);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(184, 20);
            this.txtname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qty";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.Location = new System.Drawing.Point(335, 321);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(184, 20);
            this.txtprice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(363, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(444, 355);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(279, 559);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total :  Rp.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(468, 564);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(33, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "[total]";
            // 
            // detailorderTableAdapter
            // 
            this.detailorderTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Member ID";
            // 
            // combomember
            // 
            this.combomember.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.msmemberBindingSource, "memberid", true));
            this.combomember.DataSource = this.msmemberBindingSource;
            this.combomember.DisplayMember = "memberid";
            this.combomember.FormattingEnabled = true;
            this.combomember.Location = new System.Drawing.Point(221, 50);
            this.combomember.Name = "combomember";
            this.combomember.Size = new System.Drawing.Size(184, 21);
            this.combomember.TabIndex = 16;
            this.combomember.ValueMember = "memberid";
            this.combomember.SelectionChangeCommitted += new System.EventHandler(this.Combomember_SelectionChangeCommitted);
            // 
            // msmemberBindingSource
            // 
            this.msmemberBindingSource.DataMember = "msmember";
            this.msmemberBindingSource.DataSource = this.belajar1DataSet3;
            // 
            // belajar1DataSet3
            // 
            this.belajar1DataSet3.DataSetName = "belajar1DataSet3";
            this.belajar1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // msmemberTableAdapter
            // 
            this.msmemberTableAdapter.ClearBeforeFill = true;
            // 
            // belajar1DataSet1
            // 
            this.belajar1DataSet1.DataSetName = "belajar1DataSet1";
            this.belajar1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // msmenuTableAdapter
            // 
            this.msmenuTableAdapter.ClearBeforeFill = true;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(335, 296);
            this.txtqty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(184, 20);
            this.txtqty.TabIndex = 17;
            this.txtqty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtqty.Click += new System.EventHandler(this.Txtqty_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderIDToolStripLabel,
            this.orderIDToolStripTextBox,
            this.fillByToolStripButton,
            this.labelId});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(588, 25);
            this.fillByToolStrip.TabIndex = 18;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // orderIDToolStripLabel
            // 
            this.orderIDToolStripLabel.Name = "orderIDToolStripLabel";
            this.orderIDToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.orderIDToolStripLabel.Text = "orderID:";
            // 
            // orderIDToolStripTextBox
            // 
            this.orderIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.orderIDToolStripTextBox.Name = "orderIDToolStripTextBox";
            this.orderIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click);
            // 
            // labelId
            // 
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(13, 22);
            this.labelId.Text = "0";
            // 
            // msmenuTableAdapter1
            // 
            this.msmenuTableAdapter1.ClearBeforeFill = true;
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
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderidDataGridViewTextBoxColumn.Visible = false;
            // 
            // menuidDataGridViewTextBoxColumn1
            // 
            this.menuidDataGridViewTextBoxColumn1.DataPropertyName = "menuid";
            this.menuidDataGridViewTextBoxColumn1.HeaderText = "menuid";
            this.menuidDataGridViewTextBoxColumn1.Name = "menuidDataGridViewTextBoxColumn1";
            this.menuidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.menuidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // menu
            // 
            this.menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menu.HeaderText = "Menu";
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 46;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 56;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Total";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 56;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 602);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.combomember);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictReview);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.dataGridMenu);
            this.Controls.Add(this.label1);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqty)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMenu;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.PictureBox pictReview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private belajar1DataSet4 belajar1DataSet4;
        private System.Windows.Forms.BindingSource detailorderBindingSource;
        private belajar1DataSet4TableAdapters.detailorderTableAdapter detailorderTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combomember;
        private belajar1DataSet3 belajar1DataSet3;
        private System.Windows.Forms.BindingSource msmemberBindingSource;
        private belajar1DataSet3TableAdapters.msmemberTableAdapter msmemberTableAdapter;
        private belajar1DataSet1 belajar1DataSet1;
        private belajar1DataSet2 belajar1DataSet2;
        private System.Windows.Forms.BindingSource msmenuBindingSource;
        private belajar1DataSet2TableAdapters.msmenuTableAdapter msmenuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown txtqty;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel orderIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox orderIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripLabel labelId;
        private belajar1DataSet1TableAdapters.msmenuTableAdapter msmenuTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}