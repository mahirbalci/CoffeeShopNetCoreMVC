using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StoreManager : IStoreService
    {
        private readonly IStoreDal _storeDal;
        public StoreManager(IStoreDal storeDal)
        {
            _storeDal = storeDal;       
        }
        public void Delete(Store t)
        {
            _storeDal.Delete(t);
        }

        public Store GetById(int id)
        {
            return _storeDal.GetById(id);
        }

        public List<Store> GetListAll()
        {
            return _storeDal.GetListAll();
        }

        public void Insert(Store t)
        {
            _storeDal.Insert(t);
        }

        public void Update(Store t)
        {
            _storeDal.Update(t);
        }
    }
}
