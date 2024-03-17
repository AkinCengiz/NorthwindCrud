using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindCrud.FormApp.Models;

namespace NorthwindCrud.FormApp.Services;
public class SupplierService
{
    public void AddSupplier(Supplier supplier)
    {
        NorthwndContext context = new NorthwndContext();
        context.Suppliers.Add(supplier);
        context.SaveChanges();
    }

    public List<Supplier> GetAllSupplier()
    {
        NorthwndContext context = new NorthwndContext();
        var suppliers = context.Suppliers.OrderBy(s => s.CompanyName).ToList();
        return suppliers;
    }

    public Supplier GetSupplier(int id)
    {
        NorthwndContext context = new NorthwndContext();
        Supplier supplier = context.Suppliers.FirstOrDefault(s => s.SupplierId == id);
        return supplier;
    }

    public void UpdateSupplier(Supplier supplier)
    {
        NorthwndContext context = new NorthwndContext();
        context.Suppliers.Update(supplier);
        context.SaveChanges();
    }

    public void DeleteSupplier(Supplier supplier)
    {
        NorthwndContext context = new NorthwndContext();
        context.Suppliers.Remove(supplier);
        context.SaveChanges();
    }
}
