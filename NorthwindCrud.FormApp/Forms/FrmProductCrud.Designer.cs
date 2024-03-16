namespace NorthwindCrud.FormApp.Forms;

partial class FrmProductCrud
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
        groupBox1 = new GroupBox();
        label9 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        label4 = new Label();
        label3 = new Label();
        btnUpdate = new Button();
        btnAdd = new Button();
        btnDelete = new Button();
        cbxDiscontinued = new CheckBox();
        txtReorderLevel = new TextBox();
        label2 = new Label();
        cmbSupplier = new ComboBox();
        label1 = new Label();
        txtUnitsOnOrder = new TextBox();
        cmbCategories = new ComboBox();
        txtUnitsInStock = new TextBox();
        txtUnitPrice = new TextBox();
        txtQuantity = new TextBox();
        txtProductName = new TextBox();
        txtId = new TextBox();
        groupBox2 = new GroupBox();
        dgvProducts = new DataGridView();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(btnUpdate);
        groupBox1.Controls.Add(btnAdd);
        groupBox1.Controls.Add(btnDelete);
        groupBox1.Controls.Add(cbxDiscontinued);
        groupBox1.Controls.Add(txtReorderLevel);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(cmbSupplier);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(txtUnitsOnOrder);
        groupBox1.Controls.Add(cmbCategories);
        groupBox1.Controls.Add(txtUnitsInStock);
        groupBox1.Controls.Add(txtUnitPrice);
        groupBox1.Controls.Add(txtQuantity);
        groupBox1.Controls.Add(txtProductName);
        groupBox1.Controls.Add(txtId);
        groupBox1.Font = new Font("Segoe UI", 11F);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1045, 234);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Kontrol Paneli";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(38, 184);
        label9.Name = "label9";
        label9.Size = new Size(99, 20);
        label9.TabIndex = 21;
        label9.Text = "Unit In Stock :";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(58, 147);
        label5.Name = "label5";
        label5.Size = new Size(79, 20);
        label5.TabIndex = 20;
        label5.Text = "Unit Price :";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(10, 110);
        label6.Name = "label6";
        label6.Size = new Size(127, 20);
        label6.TabIndex = 19;
        label6.Text = "Quantity Per Unit :";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(17, 72);
        label7.Name = "label7";
        label7.Size = new Size(120, 20);
        label7.TabIndex = 18;
        label7.Text = "Prooduct Name :";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(106, 36);
        label8.Name = "label8";
        label8.Size = new Size(31, 20);
        label8.TabIndex = 17;
        label8.Text = "ID :";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(385, 147);
        label4.Name = "label4";
        label4.Size = new Size(107, 20);
        label4.TabIndex = 16;
        label4.Text = "Units In Order :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(385, 110);
        label3.Name = "label3";
        label3.Size = new Size(107, 20);
        label3.TabIndex = 15;
        label3.Text = "Units In Order :";
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(805, 83);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(216, 38);
        btnUpdate.TabIndex = 14;
        btnUpdate.Text = "UPDATE PRODUCT";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(805, 33);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(216, 38);
        btnAdd.TabIndex = 13;
        btnAdd.Text = "ADD PRODUCT";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += button1_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(805, 133);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(216, 38);
        btnDelete.TabIndex = 12;
        btnDelete.Text = "DELETE PRODUCT";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // cbxDiscontinued
        // 
        cbxDiscontinued.AutoSize = true;
        cbxDiscontinued.Checked = true;
        cbxDiscontinued.CheckState = CheckState.Checked;
        cbxDiscontinued.Location = new Point(408, 183);
        cbxDiscontinued.Name = "cbxDiscontinued";
        cbxDiscontinued.Size = new Size(115, 24);
        cbxDiscontinued.TabIndex = 11;
        cbxDiscontinued.Text = "Discontinued";
        cbxDiscontinued.UseVisualStyleBackColor = true;
        // 
        // txtReorderLevel
        // 
        txtReorderLevel.Location = new Point(498, 144);
        txtReorderLevel.Name = "txtReorderLevel";
        txtReorderLevel.PlaceholderText = "Reorder Level";
        txtReorderLevel.Size = new Size(289, 27);
        txtReorderLevel.TabIndex = 10;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(421, 73);
        label2.Name = "label2";
        label2.Size = new Size(71, 20);
        label2.TabIndex = 9;
        label2.Text = "Supplier :";
        // 
        // cmbSupplier
        // 
        cmbSupplier.FormattingEnabled = true;
        cmbSupplier.Location = new Point(498, 69);
        cmbSupplier.Name = "cmbSupplier";
        cmbSupplier.Size = new Size(289, 28);
        cmbSupplier.TabIndex = 8;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(416, 36);
        label1.Name = "label1";
        label1.Size = new Size(76, 20);
        label1.TabIndex = 7;
        label1.Text = "Category :";
        // 
        // txtUnitsOnOrder
        // 
        txtUnitsOnOrder.Location = new Point(498, 107);
        txtUnitsOnOrder.Name = "txtUnitsOnOrder";
        txtUnitsOnOrder.PlaceholderText = "Units On Order";
        txtUnitsOnOrder.Size = new Size(289, 27);
        txtUnitsOnOrder.TabIndex = 6;
        // 
        // cmbCategories
        // 
        cmbCategories.FormattingEnabled = true;
        cmbCategories.Location = new Point(498, 33);
        cmbCategories.Name = "cmbCategories";
        cmbCategories.Size = new Size(289, 28);
        cmbCategories.TabIndex = 5;
        // 
        // txtUnitsInStock
        // 
        txtUnitsInStock.Location = new Point(143, 181);
        txtUnitsInStock.Name = "txtUnitsInStock";
        txtUnitsInStock.PlaceholderText = "Units In Stock";
        txtUnitsInStock.Size = new Size(233, 27);
        txtUnitsInStock.TabIndex = 4;
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Location = new Point(143, 144);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.PlaceholderText = "Unit Price";
        txtUnitPrice.Size = new Size(233, 27);
        txtUnitPrice.TabIndex = 3;
        // 
        // txtQuantity
        // 
        txtQuantity.Location = new Point(143, 107);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.PlaceholderText = "Quantity Per Unit";
        txtQuantity.Size = new Size(233, 27);
        txtQuantity.TabIndex = 2;
        // 
        // txtProductName
        // 
        txtProductName.Location = new Point(143, 70);
        txtProductName.Name = "txtProductName";
        txtProductName.PlaceholderText = "Product Name";
        txtProductName.Size = new Size(233, 27);
        txtProductName.TabIndex = 1;
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(143, 33);
        txtId.Name = "txtId";
        txtId.PlaceholderText = "Product Id";
        txtId.Size = new Size(233, 27);
        txtId.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dgvProducts);
        groupBox2.Font = new Font("Segoe UI", 11F);
        groupBox2.Location = new Point(12, 252);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1048, 515);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Product List";
        // 
        // dgvProducts
        // 
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProducts.Dock = DockStyle.Fill;
        dgvProducts.Location = new Point(3, 23);
        dgvProducts.Name = "dgvProducts";
        dgvProducts.Size = new Size(1042, 489);
        dgvProducts.TabIndex = 0;
        dgvProducts.DoubleClick += dgvProducts_DoubleClick;
        // 
        // FrmProductCrud
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.SeaGreen;
        ClientSize = new Size(1072, 779);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "FrmProductCrud";
        Text = "FrmProductCrud";
        Load += FrmProductCrud_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private TextBox txtProductName;
    private TextBox txtId;
    private GroupBox groupBox2;
    private DataGridView dgvProducts;
    private ComboBox cmbCategories;
    private TextBox txtUnitsInStock;
    private TextBox txtUnitPrice;
    private TextBox txtQuantity;
    private Label label2;
    private ComboBox cmbSupplier;
    private Label label1;
    private TextBox txtUnitsOnOrder;
    private Button btnUpdate;
    private Button btnAdd;
    private Button btnDelete;
    private CheckBox cbxDiscontinued;
    private TextBox txtReorderLevel;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label4;
    private Label label3;
    private Label label9;
}