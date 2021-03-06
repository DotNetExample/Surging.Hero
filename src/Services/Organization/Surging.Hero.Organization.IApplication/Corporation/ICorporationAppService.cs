﻿using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Hero.Common;
using Surging.Hero.Organization.IApplication.Corporation.Dtos;
using System.Threading.Tasks;

namespace Surging.Hero.Organization.IApplication.Corporation
{
    [ServiceBundle(HeroConstants.RouteTemplet)]
    public interface ICorporationAppService : IServiceKey
    {
        [HttpPost(true)]
        Task<string> Create(CreateCorporationInput input);

        [HttpPut(true)]
        Task<string> Update(UpdateCorporationInput input);

        [ServiceRoute("{id}")]
        [HttpDelete(true)]
        Task<string> Delete(long id);

        [ServiceRoute("{id}")]
        [HttpGet(true)]
        Task<GetCorporationOutput> Get(long id);
    }
}
