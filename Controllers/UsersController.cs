using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuraCheckIn.API.Data;
using SuraCheckIn.API.Dtos;

namespace SuraCheckIn.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ICheckInRepository _checkInRepository;
        private readonly IMapper _mapper;

        public UsersController(ICheckInRepository checkInRepository, IMapper mapper)
        {
            _checkInRepository = checkInRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _checkInRepository.GetUsers();
            var usersToDto = _mapper.Map<IEnumerable<UserListDto>>(users);
            return Ok(usersToDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _checkInRepository.GetUser(id);
            return Ok(user);
        }
                    
    }
}