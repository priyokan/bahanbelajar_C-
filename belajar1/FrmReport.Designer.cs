namespace belajar1
{
    partial class FrmReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.mont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindHeadOrder = new System.Windows.Forms.DataGridView();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belajar1DataSet6 = new belajar1.belajar1DataSet6();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.dateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.headerorderTableAdapter = new belajar1.belajar1DataSet6TableAdapters.headerorderTableAdapter();
            this.belajar1DataSet5 = new belajar1.belajar1DataSet5();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindHeadOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet6)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // comboFrom
            // 
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(166, 33);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(121, 21);
            this.comboFrom.TabIndex = 0;
            this.comboFrom.SelectionChangeCommitted += new System.EventHandler(this.ComboFrom_SelectionChangeCommitted);
            this.comboFrom.TextChanged += new System.EventHandler(this.ComboFrom_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(293, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(64, 21);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "generate";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // comboTo
            // 
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Location = new System.Drawing.Point(166, 61);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(121, 21);
            this.comboTo.TabIndex = 5;
            this.comboTo.TextChanged += new System.EventHandler(this.ComboTo_TextChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mont,
            this.income});
            this.dataGrid.Location = new System.Drawing.Point(24, 101);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(403, 167);
            this.dataGrid.TabIndex = 6;
            // 
            // mont
            // 
            this.mont.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mont.HeaderText = "Month ";
            this.mont.Name = "mont";
            // 
            // income
            // 
            this.income.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.income.HeaderText = "Income";
            this.income.Name = "income";
            this.income.Width = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Form Report";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(24, 274);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Income";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(403, 164);
            this.chart.TabIndex = 8;
            this.chart.Text = "chart1";
            // 
            // bindHeadOrder
            // 
            this.bindHeadOrder.AllowUserToAddRows = false;
            this.bindHeadOrder.AutoGenerateColumns = false;
            this.bindHeadOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bindHeadOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.cardnumberDataGridViewTextBoxColumn,
            this.bankDataGridViewTextBoxColumn,
            this.totalPaymentDataGridViewTextBoxColumn});
            this.bindHeadOrder.DataSource = this.headerorderBindingSource;
            this.bindHeadOrder.Location = new System.Drawing.Point(417, 60);
            this.bindHeadOrder.Name = "bindHeadOrder";
            this.bindHeadOrder.Size = new System.Drawing.Size(10, 12);
            this.bindHeadOrder.TabIndex = 9;
            this.bindHeadOrder.Visible = false;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "orderid";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "orderid";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employeeid";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employeeid";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "memberid";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "memberid";
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // cardnumberDataGridViewTextBoxColumn
            // 
            this.cardnumberDataGridViewTextBoxColumn.DataPropertyName = "cardnumber";
            this.cardnumberDataGridViewTextBoxColumn.HeaderText = "cardnumber";
            this.cardnumberDataGridViewTextBoxColumn.Name = "cardnumberDataGridViewTextBoxColumn";
            // 
            // bankDataGridViewTextBoxColumn
            // 
            this.bankDataGridViewTextBoxColumn.DataPropertyName = "bank";
            this.bankDataGridViewTextBoxColumn.HeaderText = "bank";
            this.bankDataGridViewTextBoxColumn.Name = "bankDataGridViewTextBoxColumn";
            // 
            // totalPaymentDataGridViewTextBoxColumn
            // 
            this.totalPaymentDataGridViewTextBoxColumn.DataPropertyName = "totalPayment";
            this.totalPaymentDataGridViewTextBoxColumn.HeaderText = "totalPayment";
            this.totalPaymentDataGridViewTextBoxColumn.Name = "totalPaymentDataGridViewTextBoxColumn";
            // 
            // headerorderBindingSource
            // 
            this.headerorderBindingSource.DataMember = "headerorder";
            this.headerorderBindingSource.DataSource = this.belajar1DataSet6;
            // 
            // belajar1DataSet6
            // 
            this.belajar1DataSet6.DataSetName = "belajar1DataSet6";
            this.belajar1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripLabel,
            this.dateToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(871, 25);
            this.fillByToolStrip.TabIndex = 10;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // dateToolStripLabel
            // 
            this.dateToolStripLabel.Name = "dateToolStripLabel";
            this.dateToolStripLabel.Size = new System.Drawing.Size(33, 22);
            this.dateToolStripLabel.Text = "date:";
            // 
            // dateToolStripTextBox
            // 
            this.dateToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateToolStripTextBox.Name = "dateToolStripTextBox";
            this.dateToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click);
            // 
            // headerorderTableAdapter
            // 
            this.headerorderTableAdapter.ClearBeforeFill = true;
            // 
            // belajar1DataSet5
            // 
            this.belajar1DataSet5.DataSetName = "belajar1DataSet5";
            this.belajar1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 458);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.bindHeadOrder);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.comboTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.comboFrom);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindHeadOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet6)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belajar1DataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn mont;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private belajar1DataSet5 belajar1DataSet5;
        private System.Windows.Forms.DataGridView bindHeadOrder;
        private belajar1DataSet6 belajar1DataSet6;
        private System.Windows.Forms.BindingSource headerorderBindingSource;
        private belajar1DataSet6TableAdapters.headerorderTableAdapter headerorderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel dateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dateToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}