using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project_BLL.DesignPattems.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        // List 

        List<T> GetAll();
        List<T> GetActive();
        List<T> GetPassive();
        List<T> GetUpdated();

        // Modify
        void Add(T t);
        void AddRange(List<T> list);

        void Delete(T t);
        void DeleteRange(List<T> list);

        void Update(T t);
        void UpdateRange(List<T> list);

        void Destroy(T t);
        void DestroyRange(List<T> list);

        // Linq Commands

        List<T> Where(Expression<Func<T, bool>> exp);

        bool Any(Expression<Func<T, bool>> exp);

        T FirstOrDefault(Expression<Func<T, bool>> exp);

        object Select(Expression<Func<T, object>> exp);
        IQueryable <X> Select<X>(Expression<Func<T, X>> exp);

        T Find(int id);
    }
}
