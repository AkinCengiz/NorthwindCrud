using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindCrud.FormApp.Models;

namespace NorthwindCrud.FormApp.Services;
public class CustomerService
{
    public void AddCustomer(Customer customer)
    {
        NorthwndContext context = new NorthwndContext();
        context.Customers.Add(customer);
        context.SaveChanges();
    }

    public void UpdateCustomer(Customer customer)
    {
        NorthwndContext context = new NorthwndContext();
        context.Customers.Update(customer);
        context.SaveChanges();
    }

    public void DeleteCustomer(Customer customer)
    {
        NorthwndContext context = new NorthwndContext();
        context.Customers.Remove(customer);
        context.SaveChanges();
    }

    public List<Customer> GetCustomersList()
    {
        NorthwndContext context = new NorthwndContext();
        var customers = context.Customers.OrderBy(c => c.CompanyName).ToList();
        return customers;
    }

    public Customer GetCustomer(string id)
    {
        NorthwndContext context = new NorthwndContext();
        return context.Customers.SingleOrDefault(c => c.CustomerId == id);
    }
}
