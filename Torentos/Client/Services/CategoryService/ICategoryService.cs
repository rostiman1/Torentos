﻿namespace Torentos.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        event Action OnChange; 
        List<Category> Categories { get; set; }
        List<Category> AdminCategories { get; set; }
        Task GetCategories();
        Task GetAllCategories();
        Task AddCategory(Category category);
        Task DeleteCategory(int id);
        Task UpdateCategory(Category category);
        Category CreateNewCategory();
    }
}
