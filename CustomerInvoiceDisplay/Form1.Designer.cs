namespace CustomerInvoiceDisplay
{
	partial class Form1
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
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label addressLabel;
			System.Windows.Forms.Label cityLabel;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mMABooksDataSet = new CustomerInvoiceDisplay.MMABooksDataSet();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.stateComboBox = new System.Windows.Forms.ComboBox();
			this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.zipCodeTextBox = new System.Windows.Forms.TextBox();
			this.invoicesDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fillByCustomerIDToolStrip = new System.Windows.Forms.ToolStrip();
			this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.customerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.fillByCustomerIDToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.customersTableAdapter = new CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.CustomersTableAdapter();
			this.tableAdapterManager = new CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.TableAdapterManager();
			this.invoicesTableAdapter = new CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.InvoicesTableAdapter();
			this.statesTableAdapter = new CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.StatesTableAdapter();
			this.statesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			nameLabel = new System.Windows.Forms.Label();
			addressLabel = new System.Windows.Forms.Label();
			cityLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
			this.fillByCustomerIDToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statesBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(9, 28);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(38, 13);
			nameLabel.TabIndex = 3;
			nameLabel.Text = "Name:";
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Location = new System.Drawing.Point(9, 54);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new System.Drawing.Size(48, 13);
			addressLabel.TabIndex = 5;
			addressLabel.Text = "Address:";
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Location = new System.Drawing.Point(9, 80);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(107, 13);
			cityLabel.TabIndex = 7;
			cityLabel.Text = "City, State, Zip Code:";
			// 
			// customersBindingSource
			// 
			this.customersBindingSource.DataMember = "Customers";
			this.customersBindingSource.DataSource = this.mMABooksDataSet;
			// 
			// mMABooksDataSet
			// 
			this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
			this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(83, 25);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.ReadOnly = true;
			this.nameTextBox.Size = new System.Drawing.Size(490, 20);
			this.nameTextBox.TabIndex = 4;
			// 
			// addressTextBox
			// 
			this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
			this.addressTextBox.Location = new System.Drawing.Point(83, 51);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.ReadOnly = true;
			this.addressTextBox.Size = new System.Drawing.Size(490, 20);
			this.addressTextBox.TabIndex = 6;
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
			this.cityTextBox.Location = new System.Drawing.Point(122, 77);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.ReadOnly = true;
			this.cityTextBox.Size = new System.Drawing.Size(164, 20);
			this.cityTextBox.TabIndex = 8;
			// 
			// stateComboBox
			// 
			this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
			this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource, "State", true));
			this.stateComboBox.DataSource = this.statesBindingSource;
			this.stateComboBox.DisplayMember = "StateName";
			this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stateComboBox.FormattingEnabled = true;
			this.stateComboBox.Location = new System.Drawing.Point(293, 76);
			this.stateComboBox.Name = "stateComboBox";
			this.stateComboBox.Size = new System.Drawing.Size(154, 21);
			this.stateComboBox.TabIndex = 10;
			this.stateComboBox.ValueMember = "StateCode";
			// 
			// statesBindingSource
			// 
			this.statesBindingSource.DataMember = "States";
			this.statesBindingSource.DataSource = this.mMABooksDataSet;
			// 
			// zipCodeTextBox
			// 
			this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZipCode", true));
			this.zipCodeTextBox.Location = new System.Drawing.Point(452, 77);
			this.zipCodeTextBox.Name = "zipCodeTextBox";
			this.zipCodeTextBox.ReadOnly = true;
			this.zipCodeTextBox.Size = new System.Drawing.Size(121, 20);
			this.zipCodeTextBox.TabIndex = 12;
			// 
			// invoicesDataGridView
			// 
			this.invoicesDataGridView.AllowUserToAddRows = false;
			this.invoicesDataGridView.AllowUserToDeleteRows = false;
			this.invoicesDataGridView.AutoGenerateColumns = false;
			this.invoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.invoicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
			this.invoicesDataGridView.DataSource = this.invoicesBindingSource;
			this.invoicesDataGridView.Location = new System.Drawing.Point(12, 103);
			this.invoicesDataGridView.Name = "invoicesDataGridView";
			this.invoicesDataGridView.ReadOnly = true;
			this.invoicesDataGridView.Size = new System.Drawing.Size(773, 330);
			this.invoicesDataGridView.TabIndex = 13;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID";
			this.dataGridViewTextBoxColumn1.HeaderText = "Invoice ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 80;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "InvoiceDate";
			dataGridViewCellStyle6.Format = "d";
			dataGridViewCellStyle6.NullValue = null;
			this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn3.HeaderText = "Invoice Date";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductTotal";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.Format = "C2";
			dataGridViewCellStyle7.NullValue = null;
			this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewTextBoxColumn4.HeaderText = "Product Total";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "SalesTax";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle8.Format = "C2";
			dataGridViewCellStyle8.NullValue = null;
			this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewTextBoxColumn5.HeaderText = "Sales Tax";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 80;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Shipping";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.Format = "C2";
			dataGridViewCellStyle9.NullValue = null;
			this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewTextBoxColumn6.HeaderText = "Shipping";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 80;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "InvoiceTotal";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.Format = "C2";
			dataGridViewCellStyle10.NullValue = null;
			this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridViewTextBoxColumn7.HeaderText = "Invoice Total";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// invoicesBindingSource
			// 
			this.invoicesBindingSource.DataMember = "Invoices";
			this.invoicesBindingSource.DataSource = this.mMABooksDataSet;
			// 
			// fillByCustomerIDToolStrip
			// 
			this.fillByCustomerIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel,
            this.customerIDToolStripTextBox,
            this.fillByCustomerIDToolStripButton});
			this.fillByCustomerIDToolStrip.Location = new System.Drawing.Point(0, 0);
			this.fillByCustomerIDToolStrip.Name = "fillByCustomerIDToolStrip";
			this.fillByCustomerIDToolStrip.Size = new System.Drawing.Size(800, 25);
			this.fillByCustomerIDToolStrip.TabIndex = 14;
			this.fillByCustomerIDToolStrip.Text = "fillByCustomerIDToolStrip";
			// 
			// customerIDToolStripLabel
			// 
			this.customerIDToolStripLabel.Name = "customerIDToolStripLabel";
			this.customerIDToolStripLabel.Size = new System.Drawing.Size(73, 22);
			this.customerIDToolStripLabel.Text = "CustomerID:";
			// 
			// customerIDToolStripTextBox
			// 
			this.customerIDToolStripTextBox.Name = "customerIDToolStripTextBox";
			this.customerIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
			// 
			// fillByCustomerIDToolStripButton
			// 
			this.fillByCustomerIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fillByCustomerIDToolStripButton.Name = "fillByCustomerIDToolStripButton";
			this.fillByCustomerIDToolStripButton.Size = new System.Drawing.Size(122, 22);
			this.fillByCustomerIDToolStripButton.Text = "Filter by Customer ID";
			this.fillByCustomerIDToolStripButton.Click += new System.EventHandler(this.fillByCustomerIDToolStripButton_Click);
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
			this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
			this.tableAdapterManager.StatesTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = CustomerInvoiceDisplay.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// invoicesTableAdapter
			// 
			this.invoicesTableAdapter.ClearBeforeFill = true;
			// 
			// statesTableAdapter
			// 
			this.statesTableAdapter.ClearBeforeFill = true;
			// 
			// statesBindingSource1
			// 
			this.statesBindingSource1.DataMember = "States";
			this.statesBindingSource1.DataSource = this.mMABooksDataSet;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 442);
			this.Controls.Add(this.fillByCustomerIDToolStrip);
			this.Controls.Add(this.invoicesDataGridView);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(addressLabel);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(cityLabel);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.stateComboBox);
			this.Controls.Add(this.zipCodeTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
			this.fillByCustomerIDToolStrip.ResumeLayout(false);
			this.fillByCustomerIDToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.statesBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MMABooksDataSet mMABooksDataSet;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private MMABooksDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private MMABooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private MMABooksDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
		private System.Windows.Forms.BindingSource invoicesBindingSource;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.ComboBox stateComboBox;
		private System.Windows.Forms.TextBox zipCodeTextBox;
		private System.Windows.Forms.DataGridView invoicesDataGridView;
		private System.Windows.Forms.ToolStrip fillByCustomerIDToolStrip;
		private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox;
		private System.Windows.Forms.ToolStripButton fillByCustomerIDToolStripButton;
		private System.Windows.Forms.BindingSource statesBindingSource;
		private MMABooksDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
		private System.Windows.Forms.BindingSource statesBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
	}
}

