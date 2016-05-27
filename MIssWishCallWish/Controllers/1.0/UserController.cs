using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MissWish.Controllers._1._0
{
    public class UserController : ApiController
    {
        [Route("api/user")]
        public string Getusers()
        {
            return "User controller";
        }
    }
}
