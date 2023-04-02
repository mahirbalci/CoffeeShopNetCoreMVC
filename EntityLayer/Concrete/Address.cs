using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Address:IEntity
    {
        public int AddressId { get; set; }
        public string Description { get; set; }
        public string SeconDescription { get; set; }
        public string Phone { get; set; }
    }
}
