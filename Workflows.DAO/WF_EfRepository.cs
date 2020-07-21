﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workflows.DAO
{
    public class WF_EfRepository<TEntity> : WF_IRepository<TEntity> where TEntity : class
    {
        private WF_GeneralDbContext _dbContext;

        public WF_EfRepository(WF_GeneralDbContext generalDbContext)
        {
            this._dbContext = generalDbContext;
        }

        public DbContext DbContext
        {
            get
            {
                return _dbContext;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<TEntity> Entities
        {
            get
            {
                return _dbContext.Set<TEntity>();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IQueryable<TEntity> Table
        {
            get
            {
                return Entities;
            }
        }

        public void delete(TEntity entity, bool isSave = true)
        {
            Entities.Remove(entity);
            if (isSave)
                _dbContext.SaveChanges();
        }

        public IQueryable<TEntity> ExcuteQuery(string sql, params object[] parameters)
        {
           return Entities.FromSql<TEntity>(sql, parameters);
            
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity getById(object id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void insert(TEntity entity, bool isSave = true)
        {
            Entities.Add(entity);
            if (isSave)
                _dbContext.SaveChanges();
        }

        public void update(TEntity entity, bool isSave = true)
        {
            if (isSave)
                _dbContext.SaveChanges();
        }
    }
}