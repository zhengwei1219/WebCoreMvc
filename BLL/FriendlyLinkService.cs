using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Caching.Memory;
using Model;

namespace BLL
{
    public class FriendlyLinkService : IFriendlyLinkService
    {
        private IMemoryCache _memoryCache;
        private const string MODEL_KEY = "General.services.friendlyLink_{0}";

        private IRepository<FriendlyLink> _friendlyLinkRepository;
        public FriendlyLinkService(IRepository<FriendlyLink> friendlyLinkRepository, IMemoryCache memoryCache)
        {
            this._memoryCache = memoryCache;
            this._friendlyLinkRepository = friendlyLinkRepository;
        }
        public void Add(FriendlyLink friendlyLink)
        {
            _friendlyLinkRepository.insert(friendlyLink, true);
        }

        public IQueryable<FriendlyLink> GetAll()
        {
            return _friendlyLinkRepository.Table;
        }

        public FriendlyLink GetById(int id)
        {
           return _friendlyLinkRepository.getById(id);
        }
    }
}
