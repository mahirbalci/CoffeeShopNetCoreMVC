using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class _AboutPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;
        public _AboutPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _aboutService.GetListAll();
            return View(result);
        }
    }
}
