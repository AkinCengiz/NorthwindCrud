namespace NorthwindCrud.FormApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnProduct = new Button();
        btnCategory = new Button();
        btnCustomer = new Button();
        btnSupplier = new Button();
        SuspendLayout();
        // 
        // btnProduct
        // 
        btnProduct.BackColor = Color.ForestGreen;
        btnProduct.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnProduct.ForeColor = Color.White;
        btnProduct.Location = new Point(12, 12);
        btnProduct.Name = "btnProduct";
        btnProduct.Size = new Size(106, 115);
        btnProduct.TabIndex = 0;
        btnProduct.Text = "Product Module";
        btnProduct.UseVisualStyleBackColor = false;
        btnProduct.Click += btnProduct_Click;
        // 
        // btnCategory
        // 
        btnCategory.BackColor = Color.ForestGreen;
        btnCategory.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnCategory.ForeColor = Color.White;
        btnCategory.Location = new Point(124, 12);
        btnCategory.Name = "btnCategory";
        btnCategory.Size = new Size(106, 115);
        btnCategory.TabIndex = 1;
        btnCategory.Text = "Category Module";
        btnCategory.UseVisualStyleBackColor = false;
        btnCategory.Click += btnCategory_Click;
        // 
        // btnCustomer
        // 
        btnCustomer.BackColor = Color.ForestGreen;
        btnCustomer.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnCustomer.ForeColor = Color.White;
        btnCustomer.Location = new Point(348, 12);
        btnCustomer.Name = "btnCustomer";
        btnCustomer.Size = new Size(106, 115);
        btnCustomer.TabIndex = 3;
        btnCustomer.Text = "Customer Module";
        btnCustomer.UseVisualStyleBackColor = false;
        btnCustomer.Click += btnCustomer_Click;
        // 
        // btnSupplier
        // 
        btnSupplier.BackColor = Color.ForestGreen;
        btnSupplier.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnSupplier.ForeColor = Color.White;
        btnSupplier.Location = new Point(236, 12);
        btnSupplier.Name = "btnSupplier";
        btnSupplier.Size = new Size(106, 115);
        btnSupplier.TabIndex = 2;
        btnSupplier.Text = "Supplier Module";
        btnSupplier.UseVisualStyleBackColor = false;
        btnSupplier.Click += btnSupplier_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.SeaGreen;
        ClientSize = new Size(800, 450);
        Controls.Add(btnCustomer);
        Controls.Add(btnSupplier);
        Controls.Add(btnCategory);
        Controls.Add(btnProduct);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button btnProduct;
    private Button btnCategory;
    private Button btnCustomer;
    private Button btnSupplier;
}
