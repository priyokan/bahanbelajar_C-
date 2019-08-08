namespace belajar1
{
    partial class FrmVIewOreder
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
            this.comboID = new System.Windows.Forms.ComboBox();
            this.headerorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belajar1DataSet5 = new belajar1.belajar1DataSet5();
            this.detailorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belajar1DataSet4 = new belajar1.belajar1DataSet4();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.detailidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.detailorderTableAdapter = new belajar1.belajar1DataSet4TableAdapters.detailorderTableAdapter();
            this.belajar1DataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headerorderTableAdapter = new belajar1.belajar1DataSet5TableAdapters.headerorderTableAdapter();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.orderidParamsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.orderidtooltip = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.headerorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5BindingSource)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form View Order";
            // 
            // comboID
            // 
            this.comboID.DataSource = this.headerorderBindingSource;
            this.comboID.DisplayMember = "orderid";
            this.comboID.FormattingEnabled = true;
            this.comboID.Location = new System.Drawing.Point(192, 65);
            this.comboID.Name = "comboID";
            this.comboID.Size = new System.Drawing.Size(189, 21);
            this.comboID.TabIndex = 1;
            this.comboID.ValueMember = "orderid";
            this.comboID.TextChanged += new System.EventHandler(this.ComboBox1_TextChanged);
            // 
            // headerorderBindingSource
            // 
            this.headerorderBindingSource.DataMember = "headerorder";
            this.headerorderBindingSource.DataSource = this.belajar1DataSet5;
            // 
            // belajar1DataSet5
            // 
            this.belajar1DataSet5.DataSetName = "belajar1DataSet5";
            this.belajar1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order ID";
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToOrderColumns = true;
            this.dataGridOrder.AutoGenerateColumns = false;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailidDataGridViewTextBoxColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.menuidDataGridViewTextBoxColumn,
            this.Menu,
            this.qtyDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridOrder.DataSource = this.detailorderBindingSource;
            this.dataGridOrder.Location = new System.Drawing.Point(12, 104);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(535, 220);
            this.dataGridOrder.TabIndex = 3;
            this.dataGridOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridOrder_CellClick);
            this.dataGridOrder.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridOrder_CellEnter);
            this.dataGridOrder.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGridOrder_EditingControlShowing);
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
            // Menu
            // 
            this.Menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Menu.DataPropertyName = "detailid";
            this.Menu.HeaderText = "Menu";
            this.Menu.Name = "Menu";
            this.Menu.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 46;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "ordered",
            "pending",
            "cooking",
            "cooked"});
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // detailorderTableAdapter
            // 
            this.detailorderTableAdapter.ClearBeforeFill = true;
            // 
            // belajar1DataSet5BindingSource
            // 
            this.belajar1DataSet5BindingSource.DataSource = this.belajar1DataSet5;
            this.belajar1DataSet5BindingSource.Position = 0;
            // 
            // headerorderTableAdapter
            // 
            this.headerorderTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderidParamsToolStripLabel,
            this.orderidtooltip,
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(567, 25);
            this.fillBy2ToolStrip.TabIndex = 4;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Visible = false;
            // 
            // orderidParamsToolStripLabel
            // 
            this.orderidParamsToolStripLabel.Name = "orderidParamsToolStripLabel";
            this.orderidParamsToolStripLabel.Size = new System.Drawing.Size(87, 22);
            this.orderidParamsToolStripLabel.Text = "orderidParams:";
            // 
            // orderidtooltip
            // 
            this.orderidtooltip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.orderidtooltip.Name = "orderidtooltip";
            this.orderidtooltip.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.FillBy2ToolStripButton_Click);
            // 
            // FrmVIewOreder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 395);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboID);
            this.Controls.Add(this.label1);
            this.Name = "FrmVIewOreder";
            this.Text = "FrmVIewOreder";
            this.Load += new System.EventHandler(this.FrmVIewOreder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5BindingSource)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private belajar1DataSet4 belajar1DataSet4;
        private System.Windows.Forms.BindingSource detailorderBindingSource;
        private belajar1DataSet4TableAdapters.detailorderTableAdapter detailorderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private belajar1DataSet5 belajar1DataSet5;
        private System.Windows.Forms.BindingSource belajar1DataSet5BindingSource;
        private System.Windows.Forms.BindingSource headerorderBindingSource;
        private belajar1DataSet5TableAdapters.headerorderTableAdapter headerorderTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripLabel orderidParamsToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox orderidtooltip;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
    }
}