using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindCrud.FormApp.Models;

namespace NorthwindCrud.FormApp.Forms;
public partial class FrmProductCrud : Form
{
    public FrmProductCrud()
    {
        InitializeComponent();
    }

    private void FrmProductCrud_Load(object sender, EventArgs e)
    {
        LoadControls();
    }

    void LoadControls()
    {
        NorthwndContext context = new NorthwndContext();
        dgvProducts.DataSource = context.Products.ToList();
        cmbCategories.DataSource = context.Categories.ToList();
        cmbCategories.DisplayMember = "CategoryName";
        cmbCategories.ValueMember = "CategoryID";
        cmbSupplier.DataSource = context.Suppliers.ToList();
        cmbSupplier.DisplayMember = "CompanyName";
        cmbSupplier.ValueMember = "SupplierID";
    }

    void ClearControls()
    {
        txtId.Clear();
        txtProductName.Clear();
        txtQuantity.Clear();
        txtReorderLevel.Clear();
        txtUnitPrice.Clear();
        txtUnitsInStock.Clear();
        txtUnitsOnOrder.Clear();
        cmbCategories.SelectedIndex = 0;
        cmbSupplier.SelectedIndex = 0;
        cbxDiscontinued.Select();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Product product = new Product()
        {
            ProductName = txtProductName.Text,
            SupplierId = (int)cmbSupplier.SelectedValue,
            CategoryId = (int)cmbCategories.SelectedValue,
            QuantityPerUnit = txtQuantity.Text,
            UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
            UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text),
            UnitsOnOrder = Convert.ToInt16(txtUnitsOnOrder.Text),
            ReorderLevel = Convert.ToInt16(txtReorderLevel.Text),
            Discontinued = cbxDiscontinued.Checked ? true : false
        };
        NorthwndContext context = new NorthwndContext();
        context.Products.Add(product);
        context.SaveChanges();
        LoadControls();
        ClearControls();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        NorthwndContext context = new NorthwndContext();
        Product product = context.Products.FirstOrDefault(p => p.ProductId == Convert.ToInt32(txtId.Text));
        product.ProductName = txtProductName.Text;
        product.CategoryId = Convert.ToInt32(cmbCategories.SelectedValue);
        product.SupplierId = Convert.ToInt32(cmbSupplier.SelectedValue);
        product.QuantityPerUnit = txtQuantity.Text;
        product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
        product.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
        product.UnitsOnOrder = Convert.ToInt16(txtUnitsOnOrder.Text);
        product.ReorderLevel = Convert.ToInt16(txtReorderLevel.Text);
        product.Discontinued = cbxDiscontinued.Checked ? true : false;
        context.Products.Update(product);
        context.SaveChanges();
        LoadControls();
        ClearControls();
    }

    private void dgvProducts_DoubleClick(object sender, EventArgs e)
    {
        NorthwndContext context = new NorthwndContext();
        Product product =
            context.Products.FirstOrDefault(p => p.ProductId == Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value));
        txtId.Text = product.ProductId.ToString();
        txtProductName.Text = product.ProductName;
        cmbSupplier.SelectedValue = product.SupplierId;
        cmbCategories.SelectedValue = product.CategoryId;
        txtQuantity.Text = product.QuantityPerUnit;
        txtUnitPrice.Text = product.UnitPrice.ToString();
        txtUnitsInStock.Text = product.UnitsInStock.ToString();
        txtUnitsOnOrder.Text = product.UnitsOnOrder.ToString();
        txtReorderLevel.Text = product.ReorderLevel.ToString();
        cbxDiscontinued.Checked = product.Discontinued;
    }
}
