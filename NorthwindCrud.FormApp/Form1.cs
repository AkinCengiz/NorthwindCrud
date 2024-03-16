using NorthwindCrud.FormApp.Forms;

namespace NorthwindCrud.FormApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnProduct_Click(object sender, EventArgs e)
    {
        FrmProductCrud frm = new FrmProductCrud();
        frm.Show();
    }

    private void btnCategory_Click(object sender, EventArgs e)
    {
        FrmCategoryCrud frm = new FrmCategoryCrud();
        frm.Show();
    }
}
