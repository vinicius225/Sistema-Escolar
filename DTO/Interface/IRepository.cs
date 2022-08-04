using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Escolar.DTO.Interface
{
    public interface IRepository<TEntity> 
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        IEnumerable<TEntity> GetAll(TEntity obj);
        TEntity GetById(string id);
        void DisableObj(string id);
    }
}