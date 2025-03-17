using BookFlow.Core.Entities;
using BookFlow.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFlow.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<int> AddASync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
