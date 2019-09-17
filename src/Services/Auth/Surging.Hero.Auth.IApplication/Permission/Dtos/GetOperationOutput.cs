﻿using Surging.Hero.Auth.IApplication.Action.Dtos;
using System.Collections.Generic;

namespace Surging.Hero.Auth.IApplication.Permission.Dtos
{
    public class GetOperationOutput : OperationDtoBase
    {
        public long Id { get; set; }

        public IEnumerable<GetActionOutput> Actions { get; set; }
    }
}
