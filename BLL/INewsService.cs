using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface INewsService
    {
        List<News> GetAll();
        News GetById(int Id);
        void Add(News news);
        
    }
}
