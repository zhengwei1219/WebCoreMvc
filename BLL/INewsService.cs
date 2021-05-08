using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public interface INewsService
    {
        IQueryable<News> GetAll();
        News GetById(int Id);
        void Add(News news);
        
    }
}
