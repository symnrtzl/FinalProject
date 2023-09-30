using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic Constraint -->Bir kısıtlama yapılması  ( where T : class)
    //Class-->referans tip
    //IEntity-->IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new()--> newlenebilir olmalı (Bunu yapmamızın sebebi IEntity'i de tek başına gönderebiliriz hata gelmez. Tek başına IEntity'i yazmamak adına new() yazarız. Çünkü IEntity newlenemez.)
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
