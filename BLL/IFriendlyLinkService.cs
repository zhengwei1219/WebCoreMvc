using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public interface IFriendlyLinkService
    {
        FriendlyLink GetById(int id);
        IQueryable<FriendlyLink> GetAll();
        void Add(FriendlyLink news);
    }
}
