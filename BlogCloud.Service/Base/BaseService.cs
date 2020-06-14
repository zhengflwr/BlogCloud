using BlogCloud.IService.Base;
using IRepository.Base;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogCloud.Service.Base
{
    public class BaseService<TEntity> : IBaseServices<TEntity> where TEntity : class, new()
    {
        public IBaseRepository<TEntity> baseDal = new BaseRepository<TEntity>();

        /// <summary>
        /// 写入实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> Add(TEntity model)
        {
            return await baseDal.Add(model);
        }

        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>

        public async Task<bool> DeleteByIds(object[] ids)
        {
            return await baseDal.DeleteByIds(ids);
        }

        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="objId"></param>
        /// <returns></returns>
        public async Task<TEntity> QueryByID(object objId)
        {
            return await baseDal.QueryByID(objId);
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> Update(TEntity model)
        {
            return await baseDal.Update(model);
        }

        Task<bool> IBaseServices<TEntity>.Add(TEntity model)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseServices<TEntity>.DeleteByIds(object[] ids)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IBaseServices<TEntity>.QueryByID(object objId)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseServices<TEntity>.Update(TEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
