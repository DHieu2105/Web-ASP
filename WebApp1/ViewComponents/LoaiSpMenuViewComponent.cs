using WebApp1.Models;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Repository;

namespace WebApp1.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSp;

        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }

        public IViewComponentResult Invoke()
        {
            var lstLoaiSp = _loaiSp.GetAllLoaiSps().OrderBy(x => x.Loai);
            return View(lstLoaiSp);
        }
    }
}
