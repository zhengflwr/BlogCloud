using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogCloud.IService;
using BlogCloud.Model.Entity;
using BlogCloud.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogCloud.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class TestUserController : BaseControllers
    {
        /// <summary>
        /// 根据id获取数据
        /// </summary>
        /// <param name="id">参数id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUser(int id)
        {
            IUserService userService = new UserService();
            User user = await userService.QueryByID(id);
            return Ok(user);
        }


        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="id">参数id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(User user)
        {
            IUserService userService = new UserService();
            var count = await userService.Add(user);
            return Ok(count);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="id">参数id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Update(User user)
        {
            IUserService userService = new UserService();
            var sucess = await userService.Update(user);
            return Ok(sucess);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id">参数id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Delete(object[] ids)
        {
            IUserService userService = new UserService();
            var sucess = await userService.DeleteByIds(ids);
            return Ok(sucess);
        }
    }
}