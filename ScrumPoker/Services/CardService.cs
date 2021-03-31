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
        private readonly DbContext _dbContext;
        public CardService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Card AddCard(Card card)
        {
            return card;
        }
    }

    interface ICardService
    {

    }
}
