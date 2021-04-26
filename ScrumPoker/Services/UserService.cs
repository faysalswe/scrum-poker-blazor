using Microsoft.EntityFrameworkCore;
using ScrumPoker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumPoker.Services
{
    public class UserService: IUserService
    {
        private readonly AppDBContext _dbContext;
        public UserService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Add(User user)
        {
            await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> Update(User user)
        {
            try
            {
                User model = _dbContext.Users.Local.FirstOrDefault(e => e.Id == user.Id);
                if (model != null)
                {
                    _dbContext.Entry(model).State = EntityState.Detached;
                }
                _dbContext.Update(user);
                await _dbContext.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<User>> GetUsersBy(string roomId)
        {
            _dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            return await _dbContext.Users
                .Where(x => x.RoomId == roomId)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<User>> Update(List<User> users)
        {
            try
            {
                List<User> models = _dbContext.Users.Local.ToList();

                foreach (var model in models)
                {
                    _dbContext.Entry(model).State = EntityState.Detached;
                }
            
                _dbContext.UpdateRange(users);
                await _dbContext.SaveChangesAsync();
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public interface IUserService
    {
        Task<User> Add(User user);
        Task<List<User>> GetUsersBy(string roomId);
        Task<User> Update(User user);
        Task<List<User>> Update(List<User> users);
    }
}
