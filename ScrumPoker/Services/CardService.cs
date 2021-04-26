using Microsoft.EntityFrameworkCore;
using ScrumPoker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumPoker.Services
{
    public class CardService : ICardService
    {
        private readonly AppDBContext _dbContext;
        public CardService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Card> AddCard(Card card)
        {
            await _dbContext.AddAsync(card);
            await _dbContext.SaveChangesAsync();
            return card;
        }

        public async Task DeleteCard(Card card)
        {
            _dbContext.Cards.Remove(card);
        }

        public async Task<List<Card>> GetCardsBy(int roomId)
        {
            return await _dbContext.Cards
                .Where(x => x.RoomId == roomId)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Card> UpdateCard(Card card)
        {
             _dbContext.Update(card);
            await _dbContext.SaveChangesAsync();
            return card;
        }
    }

    public interface ICardService
    {
        Task<Card> AddCard(Card card);
        Task<List<Card>> GetCardsBy(int roomId);
        Task<Card> UpdateCard(Card card);
        Task DeleteCard(Card card);
    }
}
