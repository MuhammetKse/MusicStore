using Microsoft.AspNetCore.Mvc;
using MusicStoreOrnek.Models;

namespace MusicStoreOrnek.Controllers
{
    public class StoreManagerController : Controller
    {
        public IActionResult Index()
        {
            //dosya ekleme işlemi için öncelikle bir tane model nesnesi oluşturalım. (tekli dosya ekleme)
            SingleFileModel model = new SingleFileModel();
            return View(model);
        }
    }
}
