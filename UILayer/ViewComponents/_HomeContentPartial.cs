using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class _HomeContentPartial:ViewComponent
    {
        private readonly IHomeContentService _homeContentService;
        public _HomeContentPartial(IHomeContentService homeContentService)
        {
            _homeContentService = homeContentService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _homeContentService.GetListAll();
            return View(result);
        }
    }
}
