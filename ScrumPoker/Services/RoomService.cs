using Microsoft.EntityFrameworkCore;
using ScrumPoker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumPoker.Services
{
    public class RoomService : IRoomService
    {
        private readonly AppDBContext _dbContext;
        public RoomService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Room> Add(Room room)
        {
            await _dbContext.AddAsync(room);
            await _dbContext.SaveChangesAsync();
            return room;
        }

        public async Task<Room> Get(string Id)
        {
            return await _dbContext.Rooms.FindAsync(Id);
        }

        public async Task<Room> Update(Room room)
        {
            User model = _dbContext.Users.Local.FirstOrDefault(e => e.Id == room.Id);
            if (model != null)
            {
                _dbContext.Entry(model).State = EntityState.Detached;
            }
            _dbContext.Update(room);
            await _dbContext.SaveChangesAsync();
            return room;
        }
    }

    public interface IRoomService
    {
        Task<Room> Add(Room room);
        Task<Room> Update(Room room);
        Task<Room> Get(string Id);
    }

}
