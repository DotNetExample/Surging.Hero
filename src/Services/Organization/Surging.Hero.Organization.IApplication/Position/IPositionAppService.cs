﻿using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Hero.Common;
using Surging.Hero.Common.Dtos;
using Surging.Hero.Organization.IApplication.Position.Dtos;
using System.Threading.Tasks;

namespace Surging.Hero.Organization.IApplication.Position
{
    [ServiceBundle(HeroConstants.RouteTemplet)]
    public interface IPositionAppService : IServiceKey
    {
        [ServiceRoute("{id}")]
        [HttpGet(true)]
        Task<GetPositionOutput> Get(long id);

        [HttpPost(true)]
        Task<string> Create(CreatePositionInput input);

        [HttpPut(true)]
        Task<string> Update(UpdatePositionInput input);

        [HttpDelete(true)]
        Task<string> Delete(DeleteByIdInput input);

        [Service(DisableNetwork = true)]
        [HttpPost(true)]
        Task<bool> Check(long positionId);
    }
}
