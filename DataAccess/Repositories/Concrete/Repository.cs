using Core.Entity.Concrete;
using Core.Enum;
using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccess.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : CoreEntity
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Durum u false olan yani silinmiş olan kaydı aktif hale getiren mettotur.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Activate(Guid id)
        {
            T activated = GetById(id);
            activated.Status = Status.Active;
            return Update(activated);
        }
        /// <summary>
        /// Database e nesne eklemeyi sağlayan metottur.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Add(T item)
        {
            _context.Set<T>().Add(item);
            return Save() > 0;
        }
        /// <summary>
        /// Liste içerisinde bulunan nesnelerin hepsini database e ekleyen metottur.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool Add(List<T> items)
        {
            _context.Set<T>().AddRange(items);
            return Save() > 0;
        }
        /// <summary>
        /// Nesnelerin bulunduğu diziden aranan nesnenin bulunup bulunmadığı bilgisini veren metottur.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Any(exp);
        }
        /// <summary>
        /// Durumu true olan aktif nesneleri getiren mettotur.
        /// </summary>
        /// <returns></returns>
        public List<T> GetActive()
        {
            return _context.Set<T>().Where(x => x.Status == Status.Active).ToList();
        }
        /// <summary>
        /// Bütün nesneleri getiren metottur.
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        /// <summary>
        /// Bir filitre expression nuna göre ilgili nesneyi getiren metottur.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp).FirstOrDefault();
        }
        /// <summary>
        /// Id si verilen nesne nin kendisini getiren metottur.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }
        /// <summary>
        /// Bir filitre expression nuna göre ilgili nesne listesini(nesneleri) getiren metottur.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp).ToList();
        }
        /// <summary>
        /// Nesnenin durumunu false yapan yani aktifliğini pasif e çeken metottur.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            item.Status = Status.Deleted;
            return Update(item);
        }
        /// <summary>
        ///  Nesnenin durumunu false yapan yani aktifliğini pasif e çeken metottur.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remove(Guid id)
        {
            try
            {
                using(TransactionScope ts = new TransactionScope())
                {
                    T deleted = GetById(id);
                    deleted.Status = Status.Deleted;
                    ts.Complete();
                    return Update(deleted);
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Nesne Listesinin(Nesnelerin) durumunu false yapan yani aktifliğini pasif e çeken metottur.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public bool RemoveAll(Expression<Func<T, bool>> exp)
        {
            using(TransactionScope ts = new TransactionScope())
            {
                List<T> collection = GetDefault(exp);
                int count = 0;
                foreach (T item in collection)
                {
                    item.Status = Status.Deleted;
                    bool result = Update(item);
                    if (result)
                    {
                        count++;
                    }
                }
                if (collection.Count == count)
                {
                    ts.Complete();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Nesneleri database e yüklenmesini sağlayan metottur.
        /// </summary>
        /// <returns></returns>
        public int Save()
        {
            return _context.SaveChanges();
        }
        /// <summary>
        /// Nesneleri güncelleyen metottur.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(T item)
        {
            try
            {
                _context.Set<T>().Update(item);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
