﻿namespace Surging.Hero.Auth.IApplication.UserGroup.Dtos
{
    public class UpdateUserGroupInput : UserGroupDtoBase
    {
        public long Id { get; set; }

        public long[] UserIds { get; set; }

        public long[] RoleIds { get; set; }
    }
}
