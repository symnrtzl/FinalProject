using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key); // cache'de var mı? varsa cache'den getir, yoksa veritabanından getir
        void Remove(string key); //cache'den atma
        void RemoveByPattern(string pattern);

    }
}
