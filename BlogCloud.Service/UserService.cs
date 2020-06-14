using BlogCloud.IService;
using BlogCloud.Model.Entity;
using System;
using BlogCloud.Service.Base;
using System.Threading.Tasks;

namespace BlogCloud.Service
{
    public class UserService : BaseService<User>, IUserService
    {
        public Task<bool> Add(User model)
        {
            BaseService<User> baseService = new BaseService<User>();
            return baseService.Add(model);
        }

        public Task<bool> DeleteByIds(object[] ids)
        {
            throw new NotImplementedException();
        }

        public Task<User> QueryByID(object objId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
