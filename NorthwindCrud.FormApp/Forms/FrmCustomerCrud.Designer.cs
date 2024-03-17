namespace NorthwindCrud.FormApp.Forms;

partial class FrmCustomerCrud
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
        label1 = new Label();
        label2 = new Label();
        txtFax = new TextBox();
        txtPhone = new TextBox();
        label10 = new Label();
        label11 = new Label();
        txtCountry = new TextBox();
        txtPostalCode = new TextBox();
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
        txtRegion = new TextBox();
        txtCity = new TextBox();
        txtAddress = new TextBox();
        txtContactTitle = new TextBox();
        groupBox2 = new GroupBox();
        dgvCustomers = new DataGridView();
        txtContactName = new TextBox();
        txtCompanyName = new TextBox();
        txtId = new TextBox();
        groupBox1 = new GroupBox();
        btnClear = new Button();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(442, 172);
        label1.Name = "label1";
        label1.Size = new Size(37, 20);
        label1.TabIndex = 29;
        label1.Text = "Fax :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(422, 138);
        label2.Name = "label2";
        label2.Size = new Size(57, 20);
        label2.TabIndex = 28;
        label2.Text = "Phone :";
        // 
        // txtFax
        // 
        txtFax.Location = new Point(485, 169);
        txtFax.Name = "txtFax";
        txtFax.PlaceholderText = "Fax";
        txtFax.Size = new Size(289, 27);
        txtFax.TabIndex = 27;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(485, 135);
        txtPhone.Name = "txtPhone";
        txtPhone.PlaceholderText = "Phone";
        txtPhone.Size = new Size(289, 27);
        txtPhone.TabIndex = 26;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(412, 104);
        label10.Name = "label10";
        label10.Size = new Size(67, 20);
        label10.TabIndex = 25;
        label10.Text = "Country :";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(385, 70);
        label11.Name = "label11";
        label11.Size = new Size(94, 20);
        label11.TabIndex = 24;
        label11.Text = "Postal Code :";
        // 
        // txtCountry
        // 
        txtCountry.Location = new Point(485, 101);
        txtCountry.Name = "txtCountry";
        txtCountry.PlaceholderText = "Country";
        txtCountry.Size = new Size(289, 27);
        txtCountry.TabIndex = 23;
        // 
        // txtPostalCode
        // 
        txtPostalCode.Location = new Point(485, 67);
        txtPostalCode.Name = "txtPostalCode";
        txtPostalCode.PlaceholderText = "Postal Code";
        txtPostalCode.Size = new Size(289, 27);
        txtPostalCode.TabIndex = 22;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(70, 180);
        label9.Name = "label9";
        label9.Size = new Size(69, 20);
        label9.TabIndex = 21;
        label9.Text = "Address :";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(39, 144);
        label5.Name = "label5";
        label5.Size = new Size(100, 20);
        label5.TabIndex = 20;
        label5.Text = "Contact Title :";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(28, 108);
        label6.Name = "label6";
        label6.Size = new Size(111, 20);
        label6.TabIndex = 19;
        label6.Text = "Contact Name :";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(19, 72);
        label7.Name = "label7";
        label7.Size = new Size(123, 20);
        label7.TabIndex = 18;
        label7.Text = "Company Name :";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(108, 36);
        label8.Name = "label8";
        label8.Size = new Size(31, 20);
        label8.TabIndex = 17;
        label8.Text = "ID :";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(416, 36);
        label4.Name = "label4";
        label4.Size = new Size(63, 20);
        label4.TabIndex = 16;
        label4.Text = "Region :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(98, 216);
        label3.Name = "label3";
        label3.Size = new Size(41, 20);
        label3.TabIndex = 15;
        label3.Text = "City :";
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(809, 78);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(216, 38);
        btnUpdate.TabIndex = 14;
        btnUpdate.Text = "UPDATE CUSTOMER";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(809, 33);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(216, 38);
        btnAdd.TabIndex = 13;
        btnAdd.Text = "ADD CUSTOMER";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(809, 122);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(216, 38);
        btnDelete.TabIndex = 12;
        btnDelete.Text = "DELETE CUSTOMER";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // txtRegion
        // 
        txtRegion.Location = new Point(485, 33);
        txtRegion.Name = "txtRegion";
        txtRegion.PlaceholderText = "Region";
        txtRegion.Size = new Size(289, 27);
        txtRegion.TabIndex = 10;
        // 
        // txtCity
        // 
        txtCity.Location = new Point(145, 213);
        txtCity.Name = "txtCity";
        txtCity.PlaceholderText = "City";
        txtCity.Size = new Size(233, 27);
        txtCity.TabIndex = 6;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(145, 177);
        txtAddress.Name = "txtAddress";
        txtAddress.PlaceholderText = "Address";
        txtAddress.Size = new Size(233, 27);
        txtAddress.TabIndex = 4;
        // 
        // txtContactTitle
        // 
        txtContactTitle.Location = new Point(145, 141);
        txtContactTitle.Name = "txtContactTitle";
        txtContactTitle.PlaceholderText = "Contact Title";
        txtContactTitle.Size = new Size(233, 27);
        txtContactTitle.TabIndex = 3;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dgvCustomers);
        groupBox2.Font = new Font("Segoe UI", 11F);
        groupBox2.Location = new Point(6, 281);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1048, 492);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Customer List";
        // 
        // dgvCustomers
        // 
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomers.Dock = DockStyle.Fill;
        dgvCustomers.Location = new Point(3, 23);
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.Size = new Size(1042, 466);
        dgvCustomers.TabIndex = 0;
        dgvCustomers.DoubleClick += dgvCustomers_DoubleClick;
        // 
        // txtContactName
        // 
        txtContactName.Location = new Point(145, 105);
        txtContactName.Name = "txtContactName";
        txtContactName.PlaceholderText = "Contact Name";
        txtContactName.Size = new Size(233, 27);
        txtContactName.TabIndex = 2;
        // 
        // txtCompanyName
        // 
        txtCompanyName.Location = new Point(145, 69);
        txtCompanyName.Name = "txtCompanyName";
        txtCompanyName.PlaceholderText = "Company Name";
        txtCompanyName.Size = new Size(233, 27);
        txtCompanyName.TabIndex = 1;
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(145, 33);
        txtId.Name = "txtId";
        txtId.PlaceholderText = "Customer Id";
        txtId.Size = new Size(233, 27);
        txtId.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnClear);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(txtFax);
        groupBox1.Controls.Add(txtPhone);
        groupBox1.Controls.Add(label10);
        groupBox1.Controls.Add(label11);
        groupBox1.Controls.Add(txtCountry);
        groupBox1.Controls.Add(txtPostalCode);
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
        groupBox1.Controls.Add(txtRegion);
        groupBox1.Controls.Add(txtCity);
        groupBox1.Controls.Add(txtAddress);
        groupBox1.Controls.Add(txtContactTitle);
        groupBox1.Controls.Add(txtContactName);
        groupBox1.Controls.Add(txtCompanyName);
        groupBox1.Controls.Add(txtId);
        groupBox1.Font = new Font("Segoe UI", 11F);
        groupBox1.Location = new Point(6, 18);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1045, 257);
        groupBox1.TabIndex = 4;
        groupBox1.TabStop = false;
        groupBox1.Text = "Kontrol Paneli";
        // 
        // btnClear
        // 
        btnClear.Location = new Point(809, 166);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(216, 38);
        btnClear.TabIndex = 30;
        btnClear.Text = "CLEAR CONTROLS";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // FrmCustomerCrud
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.SeaGreen;
        ClientSize = new Size(1061, 790);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "FrmCustomerCrud";
        Text = "FrmCustomerCrud";
        Load += FrmCustomerCrud_Load;
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtFax;
    private TextBox txtPhone;
    private Label label10;
    private Label label11;
    private TextBox txtCountry;
    private TextBox txtPostalCode;
    private Label label9;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label4;
    private Label label3;
    private Button btnUpdate;
    private Button btnAdd;
    private Button btnDelete;
    private TextBox txtRegion;
    private TextBox txtCity;
    private TextBox txtAddress;
    private TextBox txtContactTitle;
    private GroupBox groupBox2;
    private DataGridView dgvCustomers;
    private TextBox txtContactName;
    private TextBox txtCompanyName;
    private TextBox txtId;
    private GroupBox groupBox1;
    private Button btnClear;
}