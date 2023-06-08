﻿namespace ECommerce.Dominio.Services.ECommerce.Common
{
    public interface ICrudService<T> 
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);

    }
}
