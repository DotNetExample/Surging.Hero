﻿using AutoMapper;
using Surging.Hero.Auth.IApplication.UserGroup.Dtos;

namespace Surging.Hero.Auth.Application.UserGroup
{
    public class UserGroupProfile : Profile
    {
        public UserGroupProfile() {
            CreateMap<CreateUserGroupInput, Domain.UserGroups.UserGroup>();
        }
    }
}
