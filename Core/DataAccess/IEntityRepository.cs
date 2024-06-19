using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // generic constraint
    // class: referans tip
    // IEntity : IEntity olabilir ya da bundan implemente edilebilen bir nesne olabilir
    // new() : new()'lenebilen bir nesne olabilir yani soyut olan IEntity nesnesini devre dışı bırakır
    public interface IEntityRepository<T> where T : class,IEntitiy,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        // filter=null --> filtre vermeyebiliriz
        // sistemde tek bir eleman getiren kod için Get işlemini oluştururuz.
        // Expressin ile filtre veririz.
        T Get(Expression<Func<T, bool>> filter); // filtre zorunlu
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
