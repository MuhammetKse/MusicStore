using Microsoft.Build.Framework;

namespace MusicStoreOrnek.Models
{
    public class SingleFileModel : ResponseModel
    {
        //FileName: dosyanın adı
        //File    : dosyanın kendisi        
        public string FileName { get; set; }
        public IFormFile File { get; set; }       

    }


    //çoklu dosya ekleme için yeni bir class tanımlanır
    //public class MultipleFilesModel: ResponseModel
    //{
    //    public List<IFormFile> Files { get; set; }
    //}
}
