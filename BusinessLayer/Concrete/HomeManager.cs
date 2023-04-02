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
    public class HomeManager : IHomeService
    {
        private readonly IHomeDal _homeDal;
        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public void Delete(Home t)
        {
            _homeDal.Delete(t);
        }

        public Home GetById(int id)
        {
            return _homeDal.GetById(id);
        }

        public List<Home> GetListAll()
        {
            return _homeDal.GetListAll();
        }

        public void Insert(Home t)
        {
            _homeDal.Insert(t);
        }

        public void Update(Home t)
        {
            _homeDal.Update(t);
        }
    }
}
