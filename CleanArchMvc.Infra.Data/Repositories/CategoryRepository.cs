﻿using Vasis.Gestor.Domain.Entities;
using Vasis.Gestor.Domain.Interfaces;
using Vasis.Gestor.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Vasis.Gestor.Infra.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private ApplicationDbContext _categoryContext;
    public CategoryRepository(ApplicationDbContext context)
    {
        _categoryContext = context;
    }

    public async Task<Category> Create(Category category)
    {
        _categoryContext.Add(category);
        await _categoryContext.SaveChangesAsync();
        return category;
    }

    public async Task<Category> GetById(int? id)
    {
        var category = await _categoryContext.Categories.FindAsync(id);
        return category;
    }

    public async Task<IEnumerable<Category>> GetCategories()
    {
        return await _categoryContext.Categories.OrderBy(c => c.Name).ToListAsync();
    }

    public async Task<Category> Remove(Category category)
    {
        _categoryContext.Remove(category);
        await _categoryContext.SaveChangesAsync();
        return category;
    }

    public async Task<Category> Update(Category category)
    {
        _categoryContext.Update(category);
        await _categoryContext.SaveChangesAsync();
        return category;
    }
}
