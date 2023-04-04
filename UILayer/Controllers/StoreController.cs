using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
    public class StoreController : Controller
    {

        CoffeeContext c = new CoffeeContext();
        public IActionResult Index()
        {
            AddressStoreAboutViewModel p = new AddressStoreAboutViewModel();
            p.Addresses = c.Addresses.ToList();
            p.Stores = c.Stores.ToList();
            p.Abouts = c.Abouts.ToList();
            return View(p);

        }
    }
}