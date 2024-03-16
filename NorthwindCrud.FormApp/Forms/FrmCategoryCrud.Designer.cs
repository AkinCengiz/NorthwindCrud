namespace NorthwindCrud.FormApp.Forms;

partial class FrmCategoryCrud
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
        groupBox2 = new GroupBox();
        dgvCategories = new DataGridView();
        groupBox1 = new GroupBox();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        btnUpdate = new Button();
        btnAdd = new Button();
        btnDelete = new Button();
        txtPicture = new TextBox();
        txtDescription = new TextBox();
        txtCategoryName = new TextBox();
        txtId = new TextBox();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dgvCategories);
        groupBox2.Font = new Font("Segoe UI", 11F);
        groupBox2.Location = new Point(11, 204);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(948, 434);
        groupBox2.TabIndex = 3;
        groupBox2.TabStop = false;
        groupBox2.Text = "Category List";
        // 
        // dgvCategories
        // 
        dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCategories.Dock = DockStyle.Fill;
        dgvCategories.Location = new Point(3, 23);
        dgvCategories.Name = "dgvCategories";
        dgvCategories.Size = new Size(942, 408);
        dgvCategories.TabIndex = 0;
        dgvCategories.DoubleClick += dgvCategories_DoubleClick;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(btnUpdate);
        groupBox1.Controls.Add(btnAdd);
        groupBox1.Controls.Add(btnDelete);
        groupBox1.Controls.Add(txtPicture);
        groupBox1.Controls.Add(txtDescription);
        groupBox1.Controls.Add(txtCategoryName);
        groupBox1.Controls.Add(txtId);
        groupBox1.Font = new Font("Segoe UI", 11F);
        groupBox1.Location = new Point(11, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(945, 186);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Kontrol Paneli";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(76, 148);
        label5.Name = "label5";
        label5.Size = new Size(61, 20);
        label5.TabIndex = 20;
        label5.Text = "Picture :";
        label5.Visible = false;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(45, 111);
        label6.Name = "label6";
        label6.Size = new Size(92, 20);
        label6.TabIndex = 19;
        label6.Text = "Description :";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(17, 73);
        label7.Name = "label7";
        label7.Size = new Size(120, 20);
        label7.TabIndex = 18;
        label7.Text = "Category Name :";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(106, 37);
        label8.Name = "label8";
        label8.Size = new Size(31, 20);
        label8.TabIndex = 17;
        label8.Text = "ID :";
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(483, 86);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(216, 38);
        btnUpdate.TabIndex = 14;
        btnUpdate.Text = "UPDATE CATEGORY";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(483, 36);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(216, 38);
        btnAdd.TabIndex = 13;
        btnAdd.Text = "ADD CATEGORY";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(483, 136);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(216, 38);
        btnDelete.TabIndex = 12;
        btnDelete.Text = "DELETE CATEGORY";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // txtPicture
        // 
        txtPicture.Location = new Point(143, 144);
        txtPicture.Name = "txtPicture";
        txtPicture.PlaceholderText = "Picture";
        txtPicture.Size = new Size(233, 27);
        txtPicture.TabIndex = 3;
        txtPicture.Visible = false;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(143, 107);
        txtDescription.Name = "txtDescription";
        txtDescription.PlaceholderText = "Description";
        txtDescription.Size = new Size(233, 27);
        txtDescription.TabIndex = 2;
        // 
        // txtCategoryName
        // 
        txtCategoryName.Location = new Point(143, 70);
        txtCategoryName.Name = "txtCategoryName";
        txtCategoryName.PlaceholderText = "Category Name";
        txtCategoryName.Size = new Size(233, 27);
        txtCategoryName.TabIndex = 1;
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(143, 33);
        txtId.Name = "txtId";
        txtId.PlaceholderText = "Category Id";
        txtId.Size = new Size(233, 27);
        txtId.TabIndex = 0;
        // 
        // FrmCategoryCrud
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.SeaGreen;
        ClientSize = new Size(971, 646);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "FrmCategoryCrud";
        Text = "FrmCategoryCrud";
        Load += FrmCategoryCrud_Load;
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox2;
    private DataGridView dgvCategories;
    private GroupBox groupBox1;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Button btnUpdate;
    private Button btnAdd;
    private Button btnDelete;
    private TextBox txtPicture;
    private TextBox txtDescription;
    private TextBox txtCategoryName;
    private TextBox txtId;
}