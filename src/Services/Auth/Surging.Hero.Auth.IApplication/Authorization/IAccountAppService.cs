﻿using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Hero.Auth.IApplication.Authorization.Dtos;
using Surging.Hero.Common;
using System.Threading.Tasks;

namespace Surging.Hero.Auth.IApplication.Authorization
{
    [ServiceBundle(HeroConstants.RouteTemplet)]
    public interface IAccountAppService : IServiceKey
    {
        [Service(Director = Developers.Liuhll, Date = "2019-07-14", Name = "用户登录接口")]
        [HttpPost(true)]
        Task<LoginResult> Login(LoginInput input);
    }
}
