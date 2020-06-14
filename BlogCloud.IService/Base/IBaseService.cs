﻿using System;
using System.Threading.Tasks;

namespace BlogCloud.IService.Base
{
    public interface IBaseServices<TEntity> where TEntity : class
    {
        /// <summary>
        /// 根据ID列表删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<bool> DeleteByIds(object[] ids);

        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="objId"></param>
        /// <returns></returns>
        Task<TEntity> QueryByID(object objId);

        /// <summary>
        /// 添加实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> Add(TEntity model);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        Task<bool> Update(TEntity model);
    }
}
