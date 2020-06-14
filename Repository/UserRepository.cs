using BlogCloud.Model.Entity;
using IRepository;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

    }
}
