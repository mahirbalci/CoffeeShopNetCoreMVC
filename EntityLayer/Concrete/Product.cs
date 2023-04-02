using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string SecondTitle { get; set; }
        public string Description { get; set; }
    }
}
