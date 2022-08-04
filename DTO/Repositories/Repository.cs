using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema_Escolar.DTO.Interface;

namespace Sistema_Escolar.DTO.Repositories
{
    public class Repository<TEntity>   : IRepository<TEntity> where TEntity: class
    {
    private readonly AppDbContext _appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(TEntity obj)
        {
            _appDbContext.Add(obj);
            _appDbContext.SaveChanges();
        }

        public void DisableObj(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(TEntity obj)
        {
            return _appDbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(string id)
        {
            return _appDbContext.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            _appDbContext.Entry(obj).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }
    }
}