using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCloud.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseControllers : ControllerBase
    {
        //我们将路由配置统一从Controller中去掉然后endpoints.MapControllerRoute设置了路由模版，
        //由于Swagger无法在Controller中找到[Route("api/[controller]/[action]")] 和[ApiController]
        //从而触发了“No operations defined in spec!”的问题
        //解决方法:将Startup.cs中Configure里的路由模版注释掉，改成endpoints.MapControllers();
        //，增加BaseController.cs并继承ControllerBase，然后在BaseController设置路由模版，
        //让Controller继承BaseController
    }
}
