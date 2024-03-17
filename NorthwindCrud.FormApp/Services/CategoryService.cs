using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindCrud.FormApp.Models;

namespace NorthwindCrud.FormApp.Services;
public class CategoryService
{
    public List<Category> GetAllCategories()
    {
        NorthwndContext context = new NorthwndContext();
        var categories = context.Categories.OrderBy(c => c.CategoryId).ToList();
        return categories;
    }

    public void AddCategory(Category category)
    {
        NorthwndContext context = new NorthwndContext();
        context.Categories.Add(category);
        context.SaveChanges();
    }

    public void UpdateCategory(Category category)
    {
        NorthwndContext context = new NorthwndContext();
        context.Categories.Update(category);
        context.SaveChanges();
    }

    public Category GetCategory(int id)
    {
        NorthwndContext context = new NorthwndContext();
        var category = context.Categories.FirstOrDefault(c => c.CategoryId == id);
        return category;
    }
}
