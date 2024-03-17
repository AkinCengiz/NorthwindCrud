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
public partial class FrmCustomerCrud : Form
{
    public FrmCustomerCrud()
    {
        InitializeComponent();
    }

    private CustomerService _customerService;
    private void FrmCustomerCrud_Load(object sender, EventArgs e)
    {
        _customerService = new CustomerService();
        LoadControls();
    }

    void LoadControls()
    {
        dgvCustomers.DataSource = _customerService.GetCustomersList();
    }
    void ClearControl()
    {
        txtId.Clear();
        txtCompanyName.Clear();
        txtContactName.Clear();
        txtRegion.Clear();
        txtPostalCode.Clear();
        txtContactTitle.Clear();
        txtAddress.Clear();
        txtCity.Clear();
        txtCountry.Clear();
        txtPhone.Clear();
        txtFax.Clear();
    }

    private void dgvCustomers_DoubleClick(object sender, EventArgs e)
    {
        string id = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        Customer customer = _customerService.GetCustomer(id);
        if (customer != null)
        {
            txtId.Text = customer.CustomerId;
            txtCompanyName.Text = customer.CompanyName;
            txtContactName.Text = customer.ContactName;
            txtContactTitle.Text = customer.ContactTitle;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtRegion.Text = customer.Region;
            txtPostalCode.Text = customer.PostalCode;
            txtCountry.Text = customer.Country;
            txtPhone.Text = customer.Phone;
            txtFax.Text = customer.Fax;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Customer customer = new()
        {
            CompanyName = txtCompanyName.Text,
            ContactName = txtCompanyName.Text,
            ContactTitle = txtContactTitle.Text,
            Address = txtAddress.Text,
            City = txtCity.Text,
            Region = txtRegion.Text,
            PostalCode = txtPostalCode.Text,
            Country = txtCountry.Text,
            Phone = txtPhone.Text,
            Fax = txtFax.Text
        };
        _customerService.AddCustomer(customer);
        LoadControls();
        ClearControl();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        Customer customer = _customerService.GetCustomer(txtId.Text);
        customer.CompanyName = txtCompanyName.Text;
        customer.ContactName = txtContactName.Text;
        customer.ContactTitle = txtContactTitle.Text;
        customer.Address = txtAddress.Text;
        customer.City = txtCity.Text;
        customer.Region = txtRegion.Text;
        customer.PostalCode = txtPostalCode.Text;
        customer.Country = txtCountry.Text;
        customer.Phone = txtPhone.Text;
        customer.Fax = txtFax.Text;
        _customerService.UpdateCustomer(customer);
        LoadControls();
        ClearControl();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {

    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearControl();
    }
}
