﻿using System.Linq.Expressions;


namespace TaxiManagment.Domia.Interface
{
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        /// <summary>
        /// Save Entity
        /// </summary>
        /// <param name="entity"></param>
        Task<bool> Save(TEntity entity);
        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="entity"></param>
        Task<bool> Update(TEntity entity);
        /// <summary>
        /// Remove Entity
        /// </summary>
        /// <param name="entity"></param>
        Task<bool> Remove(TEntity entity);
        /// <summary>
        /// Get All data
        /// </summary>
        /// <returns></returns>
        Task<List<TEntity>> GetAll();
        /// <summary>
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<TEntity> GetEntityBy(TType Id);

        /// <summary>
        /// Exists entity
        /// </summary>
        /// <param name="filter">filter</param>
        /// <returns></returns>
        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
    }
}
