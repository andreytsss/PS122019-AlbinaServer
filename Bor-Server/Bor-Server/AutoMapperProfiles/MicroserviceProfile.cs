using Albina.BusinesLogic.Core.Models;
using AutoMapper;
using Bor.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bor_Server.AutoMapperProfiles
{
    public class MicroserviceProfile : Profile
    {
        public MicroserviceProfile()
        {
            CreateMap<UserInformationBlo, UserInformationDto>();
            CreateMap<UserIdentityBlo, UserIdentityDto>();
            CreateMap<UserIdentityDto, UserIdentityBlo>();
            CreateMap<UserUpdateDto, UserUpdateBlo>();
            CreateMap<UserUpdateBlo, UserUpdateDto>();
        }
    }
}
