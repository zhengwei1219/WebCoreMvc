using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Workflows.DAO
{
    public class BaseDao<T,ID> where T:class
    {
        WF_IRepository<T> _repository;
        public BaseDao(WF_IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Delete(T entity)
        {
            _repository.delete(entity);
        }
        public void DeletebyId(ID id)
        {
           T entity = _repository.getById(id);
            if(entity != null)
            _repository.delete(entity);
        }
        //
        // 摘要: 
        //     Loads every instance of the requested type with no filtering.
        public virtual List<T> GetAll()
        {
           return _repository.Table.ToList();
        }
        //
        // 摘要: 
        //     Loads an instance of type T from the DB based on its ID.
        public T GetById(ID id, bool shouldLock)
        {
           return _repository.getById(id);
        }
        
        public T Save(T entity)
        {
          _repository.insert(entity);
            return entity;
        }
        //
        // 摘要: 
        //     For entities with automatatically generated IDs, such as identity, SaveOrUpdate
        //     may be called when saving a new entity. SaveOrUpdate can also be called to
        //     update any entity, even if its ID is assigned.
        //
        // 参数: 
        //   entity:
        public T Update(T entity)
        {
            _repository.update(entity);
            return entity;
        }

    }
}
