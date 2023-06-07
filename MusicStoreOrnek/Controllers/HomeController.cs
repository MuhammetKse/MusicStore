using Microsoft.AspNetCore.Mvc;
using MusicStoreOrnek.Data;
using MusicStoreOrnek.Models;
using System.Diagnostics;

namespace MusicStoreOrnek.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MusicStoreContext context;

        public HomeController(ILogger<HomeController> logger, MusicStoreContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            SampleData sampleData = new SampleData(context);
            sampleData.AddGenres(); //türleri
            sampleData.AddArtist(); //sanatçıları
            sampleData.AddAlbums(); //albumleri
            //Genre genre = new Genre() { Name = "Rap", Description = "Rap" };
            //sampleData.TurEkle(genre);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult About()
        {
            return View();
        }

    }
}