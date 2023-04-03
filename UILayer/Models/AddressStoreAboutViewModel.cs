using EntityLayer.Abstract;
using EntityLayer.Concrete;

namespace PresentationLayer.Models
{
    public class AddressStoreAboutViewModel:IEntity
    {
        public List<Address> Addresses { get; set; }
        public List<Store> Stores { get; set; }
        public List<About> Abouts { get; set; }
    }
}
