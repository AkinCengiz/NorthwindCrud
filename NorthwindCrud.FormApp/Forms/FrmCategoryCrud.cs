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
public partial class FrmCategoryCrud : Form
{
    public FrmCategoryCrud()
    {
        InitializeComponent();
    }

    private CategoryService _categoryService;
    private void FrmCategoryCrud_Load(object sender, EventArgs e)
    {
        _categoryService = new CategoryService();
        LoadControls();
    }

    void LoadControls()
    {
        dgvCategories.DataSource = _categoryService.GetAllCategories();
    }

    void ClearControls()
    {
        txtId.Clear();
        txtCategoryName.Clear();
        txtDescription.Clear();
        txtPicture.Clear();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        _categoryService.AddCategory(new()
        {
            CategoryName = txtCategoryName.Text,
            Description = txtDescription.Text
        });
        LoadControls();
        ClearControls();
    }

    private void dgvCategories_DoubleClick(object sender, EventArgs e)
    {
        NorthwndContext context = new NorthwndContext();
        Category category = context.Categories.FirstOrDefault(c =>
            c.CategoryId == Convert.ToInt32(dgvCategories.CurrentRow.Cells[0].Value));
        txtId.Text = category.CategoryId.ToString();
        txtCategoryName.Text = category.CategoryName;
        txtDescription.Text = category.Description;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text);
        NorthwndContext context = new NorthwndContext();
        Category category = _categoryService.GetCategory(id);

        category.CategoryName = txtCategoryName.Text;
        category.Description = txtDescription.Text;
        _categoryService.UpdateCategory(category);
        LoadControls();
        ClearControls();
    }
}
