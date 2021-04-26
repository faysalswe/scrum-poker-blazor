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
    }

    public interface IRoomService
    {
        Task<Room> Add(Room room);
    }

}
