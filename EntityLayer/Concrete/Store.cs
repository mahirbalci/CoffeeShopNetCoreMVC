using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Store:IEntity
    {
        public int StoreId { get; set; }
        public string Title { get; set; }
        public string SecondTitle { get; set; }
        public string Days { get; set; }
        public string ClockInfo { get; set; }
      
    }
}
