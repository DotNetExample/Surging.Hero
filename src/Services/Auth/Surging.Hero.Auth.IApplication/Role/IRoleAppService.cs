﻿using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Hero.Auth.IApplication.Role.Dtos;
using Surging.Hero.Common;
using System.Threading.Tasks;

namespace Surging.Hero.Auth.IApplication.Role
{
    [ServiceBundle(HeroConstants.RouteTemplet)]
    public interface IRoleAppService : IServiceKey
    {
        Task<string> Create(CreateRoleInput input);
    }
}
