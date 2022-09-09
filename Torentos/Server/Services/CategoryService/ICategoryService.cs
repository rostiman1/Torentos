﻿namespace Torentos.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
        Task<ServiceResponse<List<Category>>> GetAllCategories();
        Task<ServiceResponse<List<Category>>> AddCategory(Category category);
        Task<ServiceResponse<List<Category>>> UpdateCategory(Category category);
        Task<ServiceResponse<List<Category>>> DeleteCategory(int id);


    }
}
