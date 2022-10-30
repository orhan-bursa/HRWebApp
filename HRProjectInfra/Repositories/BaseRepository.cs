﻿using HRProjectDomain.Entities;
using HRProjectDomain.Repositories;
using HRProjectInfra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRProjectInfrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        private readonly AppDbContext _appDbContext;
        protected DbSet<T> table;

        public BaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            table = _appDbContext.Set<T>();
        }
        public async Task<bool> Any(Expression<Func<T, bool>> expression)
        {
            return await table.AnyAsync(expression);
        }
        public async Task Create(T entity)
        {
            table.Add(entity);

            await _appDbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            //_appDbContext.Entry<T>(entity).State = EntityState.Deleted;
            //_appDbContext.Remove<T>(entity)
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<T> GetDefault(Expression<Func<T, bool>> expression)
        {
            return await table.FirstOrDefaultAsync(expression);
        }
        public async Task<List<T>> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return await table.Where(expression).ToListAsync();
        }
        public async Task<TResult> GetFilteredFirstOrDefault<TResult>(
                            Expression<Func<T, TResult>> select,
                            Expression<Func<T, bool>> where,
                            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = table; // Select * from Post
            if (where != null)
                query = query.Where(where); // Select* from where Status=1
            if (include != null)
                query = include(query);
            if (orderBy != null)
                return await orderBy(query).Select(select).FirstOrDefaultAsync();
            else
                return await query.Select(select).FirstOrDefaultAsync();
        }

        public async Task<List<TResult>> GetFilteredList<TResult>(
                            Expression<Func<T, TResult>> select,
                            Expression<Func<T, bool>> where,
                            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = table; // null?
            if (where != null)
                query = query.Where(where); // Select* from where Status=1
            if (include != null)
                query = include(query);
            if (orderBy != null)
                return await orderBy(query).Select(select).ToListAsync();
            else
                return await query.Select(select).ToListAsync();
        }

        public async Task Update(T entity)
        {
            _appDbContext.Entry<T>(entity).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
        }
    }
}
