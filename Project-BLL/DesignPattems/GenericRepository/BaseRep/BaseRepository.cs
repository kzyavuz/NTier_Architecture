using Project_BLL.DesignPattems.GenericRepository.IntRep;
using Project_BLL.DesignPattems.SinglatonPattern;
using Project_DAL.Context;
using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project_BLL.DesignPattems.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _context;

        public BaseRepository()
        {
            _context = DBTool.MyContext;
        }

        void Save()
        {
            _context.SaveChanges();
        }

        public void Add(T t)
        {
            _context.Set<T>().Add(t);
            Save();
        }

        public void AddRange(List<T> list)
        {
            _context.Set<T>().AddRange(list);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Any(exp);
        }

        public void Delete(T t)
        {
            t.Status = Project_ENTITIES.Enum.DataStatus.Delete;
            t.DeleteDate = DateTime.Now;
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (var item in list)
            {
                Delete(item);
            }
        }

        public void Destroy(T t)
        {
            _context.Set<T>().Remove(t);
            Save();
        }

        public void DestroyRange(List<T> list)
        {
            _context.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActive()
        {
            return Where(x => x.Status != Project_ENTITIES.Enum.DataStatus.Delete);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> GetPassive()
        {
            return Where(x => x.Status == Project_ENTITIES.Enum.DataStatus.Delete);
        }

        public List<T> GetUpdated()
        {
            return Where(x => x.Status == Project_ENTITIES.Enum.DataStatus.Update);
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _context.Set<T>().Select(exp);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _context.Set<T>().Where(x=>x.Status != Project_ENTITIES.Enum.DataStatus.Delete).Select(exp);
        }

        public void Update(T t)
        {
            t.Status = Project_ENTITIES.Enum.DataStatus.Update;
            t.UpdateDate = DateTime.Now;
            T unchangeEntity = Find(t.ID);
            _context.Entry(unchangeEntity).CurrentValues.SetValues(t);
            Save();
        }

        public void UpdateRange(List<T> list)
        {
            foreach(var item in list)
            {
                Update(item);
            }
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp).ToList();
        }
    }
}
