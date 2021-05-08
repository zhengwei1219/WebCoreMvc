using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Caching.Memory;
using Model;

namespace BLL
{
    public class NewsService : INewsService
    {
        private IMemoryCache _memoryCache;
        private const string MODEL_KEY = "General.services.news_{0}";

        private IRepository<News> _newsRepository;


        public NewsService(IRepository<News> newsRepository,
            IMemoryCache memoryCache)
        {
            this._newsRepository = newsRepository;
            this._memoryCache = memoryCache;
        }

        public void Add(News news)
        {
            _newsRepository.insert(news, true);
        }

        public IQueryable<News> GetAll()
        {
           return _newsRepository.Table;
        }

        public News GetById(int Id)
        {
          return  _newsRepository.getById(Id);
        }
    }
}
