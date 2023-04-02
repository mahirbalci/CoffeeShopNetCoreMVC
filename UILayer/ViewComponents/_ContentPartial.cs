using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class _ContentPartial:ViewComponent

    {
        private readonly IHomeService _homeService;
        public _ContentPartial(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _homeService.GetListAll();
            return View(result);
        }
    }
}
