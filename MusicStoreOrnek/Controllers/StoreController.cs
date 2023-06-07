using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStoreOrnek.Data;
using MusicStoreOrnek.Models;

namespace MusicStoreOrnek.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreContext context;

        public StoreController(MusicStoreContext context)
        {
            this.context = context;
        }


        // /Store/ : store/Index metodunu çağırır.
        //public string Index()
        //{
        //    return "Hello from Store.Index()";
        //}

        public IActionResult Index()
        {
            var muzikTurleri = context.Genres.ToList();
            return View(muzikTurleri);
        }



        //
        // GET: /Store/Browse
        //public string Browse()
        //{
        //    return "Hello from Store.Browse()";
        //}
        // GET: /Store/Browse?genre=Disco
        //public string Browse(string genre)
        //{
        //    string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "
        //+ genre);

        //    return message;
        //}

        //müzik albümlerini türe göre aramak istersek bu metot kullanılacak
        //public ActionResult Browse(string genre)
        //{
        //    var genreModel = new Genre { Name = genre };
        //    return View(genreModel);
        //}

        public IActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            var genreType = context.Genres.Include("Albums")
                .FirstOrDefault(satir => satir.Name == genre);
            return View(genreType);
        }

        public IActionResult Details(int id)
        {
            var album = context.Albums.Find(id);
            return View(album);
        }


        //todo
        //albums tablosundaki fiyat ve foto bilgisini details sayfasına ekleyelim.
        //update hazırlayıp boş kapak görselini projeye alıp dbdeki album kayıtlarının albumarturl bilgisini güncelleyip bakalım.

        //[HttpGet] //eğer metot tepesine hiçbir tanımlama yazmazsak bu HttpGet anlamına gelir.
        public IActionResult Olustur()
        {
            ViewBag.Artists = new SelectList(context.Artist, "ArtistId", "Name");
            ViewBag.Genres = new SelectList(context.Genres, "GenreId", "Name");
            return View();
        }

        //[HttpPost]
        //public IActionResult Olustur(Album album)
        //{
        //    context.Albums.Add(album);
        //    context.SaveChanges();
        //    return RedirectToAction("Index", "Store");
        //}


        //Listeleme metodu yardımıyla Albums sayfasında listeyi getirelim.
        public IActionResult Liste()
        {
            var albums = context.Albums.Include(satir => satir.Genre).Include(satir => satir.Artist);
            return View(albums);
        }

        //albümün bilgilerini girerken fotograf yükleme işlemini file upload yardımıyla yapalım.
        public IActionResult Olustur2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Olustur2(SingleFileModel model)
        {
            //Asp.net Core olmayan projelerde bu aşağıdaki şekilde çalışıyordu
            //if (Request.Form.Files.Count > 0)
            //{
            //    //foto seçilmiş anlamına gelir.
            //    string dosyaAdi = Path.GetFileName(Request.Form.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Form.Files[0].FileName);
            //    string yol = "~/images/" + dosyaAdi + uzanti;

            //}


            //asp.net core versiyonu
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

            //eğer wwwroot altında images dosyası yoksa oluşturur.
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            FileInfo fileInfo = new FileInfo(model.File.FileName);
            string fileName = model.FileName + fileInfo.Extension;

            string filenameWithPath = Path.Combine(path, fileName);

            using (var stream = new FileStream(filenameWithPath, FileMode.Create))
            {
                model.File.CopyTo(stream);
            }

            model.IsSuccess = true;
            model.Message = "dosya başarılı bir şekilde yüklendi";




            //album.AlbumArtUrl=...
            //context.Albums.Add(album);
            //context.SaveChanges();
            return View();
        }


        [HttpPost]
        public IActionResult Olustur(Album album)
        {
            //Asp.net Core olmayan projelerde bu aşağıdaki şekilde çalışıyordu
            //if (Request.Form.Files.Count > 0)
            //{
            //    //foto seçilmiş anlamına gelir.
            //    string dosyaAdi = Path.GetFileName(Request.Form.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Form.Files[0].FileName);
            //    string yol = "~/images/" + dosyaAdi + uzanti;

            //}


            //asp.net core versiyonu
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

            //eğer wwwroot altında images dosyası yoksa oluşturur.
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            FileInfo fileInfo = new FileInfo(album.SingleFileModel.File.FileName);
            album.SingleFileModel.FileName = fileInfo.Name;
            string fileName = album.SingleFileModel.FileName;

            string filenameWithPath = Path.Combine(path, fileName);

            using (var stream = new FileStream(filenameWithPath, FileMode.Create))
            {
                album.SingleFileModel.File.CopyTo(stream);
            }

            album.SingleFileModel.IsSuccess = true;
            album.SingleFileModel.Message = "dosya başarılı bir şekilde yüklendi";

            album.AlbumArtUrl = "../images/" + fileName;

            album.GenreId = 10;
            album.ArtistId = 90;

            context.Albums.Add(album);
            context.SaveChanges();
            return View();
        }


        //Edit sayfasını getirecek bir metot yazalım.
        //tıklanan albumun detaylarını ekrana getirsin.

        public IActionResult Edit(int id)
        {
            var album=context.Albums.Include(satir=>satir.Genre).
                                     Include(satir => satir.Artist).
                                     Where(satir => satir.AlbumId == id).
                                     FirstOrDefault();

            return View(album);
        }


        //projenin makalesi
        //https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store/

        //projenin bitmiş hali
        //https://github.com/yazilimcacsharp/MusicStore




        //API
        //Katmanlı Mimari
        //Soru Cevap






        //
        // GET: /Store/Details
        //public string Details()
        //{
        //    return "Hello from Store.Details()";
        //}

        //Store/Details?id=3 .... burada id değerini 3 olarak alır.
        //not: eğer değişkenin adı id ise bu durumda Store/Details/3 dersek de çalışır 
        //public string Details(int id)
        //{
        //    string message = "Store.Details, ID = " + id;

        //    return message;
        //}


        //bir müzik albümüne tıklanınca onun detay bilgisini getirecek metot.
        //public ActionResult Details(int id)
        //{
        //    var album = new Album { Title = "album başlıgı yazılacak " + id };
        //    return View(album);
        //}



        //değişken adı id değilse ?değişkenadi=deger şeklinde çağırmak gerekir
        //public string Details(int idim)
        //{
        //    string message = "Store.Details, ID = " + idim;

        //    return message;
        //}


        //not:
        //bir metoda arama cubugundan parametre göndermenin yolu ?degiskenAdi=degeri şeklindedir.

        //eğer değişken adınnı büyük yazarsak  ... ALIR
        //fakat değişken adını yanlış yazarsak ... ALMAZ

    }
}
