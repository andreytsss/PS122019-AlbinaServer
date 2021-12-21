using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bor.DataAccess.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bor.Core.Models;
using Albina.BusinesLogic.Core.Interfaces;
using AutoMapper;
using ServiceStack;
using Albina.BusinesLogic.Services;
using Albina.BusinesLogic.Core.Models;

namespace Bor_Server.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("/auth")]
        public async Task<ActionResult<UserInformationDto>> Auth([FromBody]UserIdentityDto userIdentityDto)
        {
            UserIdentityBlo userIdentityBlo = _mapper.Map<UserIdentityBlo>(userIdentityDto);
            UserIdentityBlo UserInformationBlo = await _userService.Auth(userIdentityBlo);
            UserInformationDto userInformationDto = _mapper.Map<UserInformationDto>(UserInformationBlo);
            return userInformationDto;
        }

        [HttpPost("/register")]
        public async Task<ActionResult<UserInformationDto>> Register([FromBody]UserIdentityDto userIdentityDto)
        {
            UserIdentityBlo userIdentityBlo = _mapper.Map<UserIdentityBlo>(userIdentityDto);
            UserIdentityBlo UserInformationBlo = await _userService.Register(userIdentityBlo);
            UserInformationDto userInformationDto = _mapper.Map<UserInformationDto>(UserInformationBlo);
            await _userService.Register(userIdentityBlo);
            return userInformationDto;
        }

        public async Task<ActionResult<UserInformationDto>> Update([FromBody] UserIdentityDto userIdentityDto)
        {
            
        }
    }
}
