using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStoreOrnek.Models
{
    public class Album
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public double ListPrice { get; set; }
        //public string ImagePath { get; set; }
        //public int GenreId { get; set; }
        //public string Title { get; set; }

        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
        public bool IsActive { get; set; }


        [NotMapped]
        public SingleFileModel SingleFileModel { get; set; }
    }
}
