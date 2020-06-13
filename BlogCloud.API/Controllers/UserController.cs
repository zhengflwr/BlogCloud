using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogCloud.API.Auth;
using BlogCloud.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogCloud.API.Controllers
{
    /// <summary>
    /// Get请求 holle
    /// </summary>
    /// <returns>Holle Word!</returns>
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    public class UserController : BaseControllers
    {
        [HttpGet]
        public IActionResult GetHello()
        {
            return Ok("Holle Word!");
        }

        /// <summary>
        /// 获取User实体
        /// </summary>
        /// <param name="user">用户</param>
        /// <returns></returns>
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPost]
        public IActionResult User(User user)
        {
            return Ok(user);
        }

        [HttpGet]

        public IActionResult Login(string role)
        {
            string jwtStr = string.Empty;
            bool suc = false;

            if (role != null)
            {
                // 将用户id和角色名，作为单独的自定义变量封装进 token 字符串中。
                TokenModel tokenModel = new TokenModel { Uid = "abcde", Role = role };
                jwtStr = JwtHelper.IssueJwt(tokenModel);//登录，获取到一定规则的 Token 令牌
                suc = true;
            }
            else
            {
                jwtStr = "login fail!!!";
            }

            return Ok(new
            {
                success = suc,
                token = jwtStr
            });
        }
    }
}