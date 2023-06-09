﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About :IEntity
    {
        public int AboutId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageClass { get; set; }
        public string Title { get; set; }
        public string SecondTitle { get; set; }
        public string Description { get; set; }
        public string SecondDescription { get; set; }
    }
}
