using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RockeseatAuction.API.Contracts;
using RockeseatAuction.API.Entities;
using RockeseatAuction.API.Repositories;

namespace RockeseatAuction.API.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool ExistUserWithEmail(string email)
        {
            return _appDbContext.Users.Any(x => x.Email.Equals(email));
        }
        public User? GetUserByEmail(string email)
        {
            return _appDbContext.Users.AsNoTracking().FirstOrDefault(x => x.Email.Equals(email));
        }
    }
}