using System.Collections.Generic;
using FriendApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FriendApi.Controllers
{
    [ApiController]
    [Route("api/friend")]
    [Authorize]
    public class FriendController : ControllerBase
    {
        private readonly FriendDbContext _context;

        public FriendController(FriendDbContext context)
        {
            _context = context;
        }
        
        [Authorize]
        public IEnumerable<Friend> GetAllFriends()
        {
            return _context.Friends;
        }
    }
}