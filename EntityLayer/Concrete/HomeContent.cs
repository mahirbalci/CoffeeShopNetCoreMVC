using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HomeContent:IEntity
    {
        public int HomeContentId { get; set; }
        public string Title { get; set; }
        public string SecondTitle { get; set; }
        public string Description { get; set; }
    }
}
