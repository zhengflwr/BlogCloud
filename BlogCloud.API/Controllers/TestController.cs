using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace BlogCloud.API.Controllers
{
    public class TestController : BaseControllers
    {
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        [HttpGet]
        public int Sum(int i, int j)
        {
            ITestRepository testService = new TestRepository();
            return testService.Sum(i, j);
        }
    }
}