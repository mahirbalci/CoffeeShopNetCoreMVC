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
    public class HomeContentManager : IHomeContentService
    {
        private readonly IHomeContentDal _homeContentDal;
        public HomeContentManager(IHomeContentDal homeContentDal)
        {
            _homeContentDal = homeContentDal;
        }

        public void Delete(HomeContent t)
        {
            _homeContentDal.Delete(t);
        }

        public HomeContent GetById(int id)
        {
            return _homeContentDal.GetById(id);
        }

        public List<HomeContent> GetListAll()
        {
            return _homeContentDal.GetListAll();
        }

        public void Insert(HomeContent t)
        {
            _homeContentDal.Insert(t);
        }

        public void Update(HomeContent t)
        {
            _homeContentDal.Update(t);
        }
    }
}
