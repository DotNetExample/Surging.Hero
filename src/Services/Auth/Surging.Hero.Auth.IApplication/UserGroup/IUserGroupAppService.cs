﻿using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Hero.Auth.IApplication.UserGroup.Dtos;
using Surging.Hero.Common;
using System.Threading.Tasks;

namespace Surging.Hero.Auth.IApplication.UserGroup
{
    [ServiceBundle(HeroConstants.RouteTemplet)]
    public interface IUserGroupAppService : IServiceKey
    {
        [HttpPost(true)]
        Task<string> Create(CreateUserGroupInput input);
    }
}
