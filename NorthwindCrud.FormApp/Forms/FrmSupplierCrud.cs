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
using NorthwindCrud.FormApp.Services;

namespace NorthwindCrud.FormApp.Forms;
public partial class FrmSupplierCrud : Form
{
    public FrmSupplierCrud()
    {
        InitializeComponent();
    }

    private SupplierService _supplierService;
    private void FrmSupplierCrud_Load(object sender, EventArgs e)
    {
        _supplierService = new SupplierService();
        LoadControls();
    }

    void LoadControls()
    {
        dgvSuppliers.DataSource = _supplierService.GetAllSupplier();
    }


    private void dgvSuppliers_DoubleClick(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells[0].Value);
        Supplier supplier = _supplierService.GetSupplier(id);
        txtId.Text = supplier.SupplierId.ToString();
        txtAddress.Text = supplier.Address;
        txtCity.Text = supplier.City;
        txtCompanyName.Text = supplier.CompanyName;
        txtPhone.Text = supplier.Phone;
        txtCountry.Text = supplier.Country;
        txtContactTitle.Text = supplier.ContactTitle;
        txtContactName.Text = supplier.ContactName;
        txtRegion.Text = supplier.Region;
        txtPostalCode.Text = supplier.PostalCode;
        txtHomePage.Text = supplier.HomePage;
        txtFax.Text = supplier.Fax;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Supplier supplier = new()
        {
            CompanyName = txtCompanyName.Text,
            ContactName = txtContactName.Text,
            ContactTitle = txtContactTitle.Text,
            Address = txtAddress.Text,
            City = txtCity.Text,
            Region = txtRegion.Text,
            PostalCode = txtPostalCode.Text,
            Country = txtCountry.Text,
            Phone = txtPhone.Text,
            Fax = txtFax.Text,
            HomePage = txtHomePage.Text
        };
        _supplierService.AddSupplier(supplier);
        LoadControls();
        ClearControl();
    }

    void ClearControl()
    {
        txtId.Clear();
        txtCompanyName.Clear();
        txtContactName.Clear();
        txtRegion.Clear();
        txtPostalCode.Clear();
        txtHomePage.Clear();
        txtContactTitle.Clear();
        txtAddress.Clear();
        txtCity.Clear();
        txtCountry.Clear();
        txtPhone.Clear();
        txtFax.Clear();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text);
        Supplier supplier = _supplierService.GetSupplier(id);
        if (supplier != null)
        {
            supplier.CompanyName = txtCompanyName.Text;
            supplier.ContactName = txtContactName.Text;
            supplier.ContactTitle = txtContactTitle.Text;
            supplier.Address = txtAddress.Text;
            supplier.City = txtCity.Text;
            supplier.Region = txtRegion.Text;
            supplier.PostalCode = txtPostalCode.Text;
            supplier.Country = txtCountry.Text;
            supplier.Phone = txtPhone.Text;
            supplier.Fax = txtFax.Text;
            supplier.HomePage = txtHomePage.Text;
        }
        _supplierService.UpdateSupplier(supplier);
        LoadControls();
        ClearControl();
    }
}
