﻿using MusicStoreOrnek.Models;

namespace MusicStoreOrnek.Data
{
    public class SampleData
    {
        private readonly MusicStoreContext musicStoreContext;

        public SampleData(MusicStoreContext _context)
        {
            musicStoreContext = _context;
        }

        //yeni bir metot yazalım.
        //metot parametre olarak Genre türünden bir müzik türü nesnesi alsın, değeri Rap olsun, description rap olsun. 
        //eğer veritabanındaki tabloda bu veri önceden eklenmişse hiçbirşey yapmasın, tabloda yoksa eklesin.
        //türleri ekleyecek kodu yazalım.
        public void TurEkle(Genre muzikTuru)
        {
            Genre genre=musicStoreContext.Genres.Where(satir => satir.Name == muzikTuru.Name).FirstOrDefault();
            //genre = new Genre();
            //if (genre != null && !String.IsNullOrWhiteSpace(genre.Name))
            //{
            //    //veri tabanında tabloda bu kayıt var.
            //}
            //else
            //{
            //    musicStoreContext.Genres.Add(muzikTuru);
            //    musicStoreContext.SaveChanges();
            //}              

            if (genre==null)
            {
                musicStoreContext.Genres.Add(muzikTuru);
                musicStoreContext.SaveChanges();
            }            
        }
        //sanatcı adsoyad bilgisini kontrollü denetimli eklenecek şekilde kodlayınız.
        public void SanatciEkle(Artist artistTuru)
        {
            Artist artist = musicStoreContext.Artist.Where(satir => satir.Name == artistTuru.Name).FirstOrDefault();                     

            if (artist == null)
            {
                musicStoreContext.Artist.Add(artist);
                musicStoreContext.SaveChanges();
            }
        }

        public void AddGenres()
        {
            if (musicStoreContext.Genres.ToList().Count == 0)           
            {
                var genres = new List<Genre>
            {
                new Genre { Name = "Rock" ,Description="Rock" },
                new Genre { Name = "Jazz" ,Description="Jazz"},
                new Genre { Name = "Metal",Description="Metal" },
                new Genre { Name = "Alternative", Description="Alternative" },
                new Genre { Name = "Disco" ,Description="Disco" },
                new Genre { Name = "Blues", Description="Blues" },
                new Genre { Name = "Latin" , Description = "Latin"},
                new Genre { Name = "Reggae" , Description="Reggae"},
                new Genre { Name = "Pop",Description="Pop" },
                new Genre { Name = "Classical",Description="Classical" }
            };

                //context'e gidip context içerisindeki genres tablosuna yukarıdaki verileri ekle.

                foreach (var item in genres)
                {
                    musicStoreContext.Genres.Add(item);
                    musicStoreContext.SaveChanges();
                }
            }
        }

        public void AddArtist()
        {
            if (musicStoreContext.Artist.ToList().Count == 0)
            {
                var artists = new List<Artist>
            {
                new Artist { Name = "Aaron Copland & London Symphony Orchestra" },
                new Artist { Name = "Aaron Goldberg" },
                new Artist { Name = "AC/DC" },
                new Artist { Name = "Accept" },
                new Artist { Name = "Adrian Leaper & Doreen de Feis" },
                new Artist { Name = "Aerosmith" },
                new Artist { Name = "Aisha Duo" },
                new Artist { Name = "Alanis Morissette" },
                new Artist { Name = "Alberto Turco & Nova Schola Gregoriana" },
                new Artist { Name = "Alice In Chains" },
                new Artist { Name = "Amy Winehouse" },
                new Artist { Name = "Anita Ward" },
                new Artist { Name = "Antônio Carlos Jobim" },
                new Artist { Name = "Apocalyptica" },
                new Artist { Name = "Audioslave" },
                new Artist { Name = "Barry Wordsworth & BBC Concert Orchestra" },
                new Artist { Name = "Berliner Philharmoniker & Hans Rosbaud" },
                new Artist { Name = "Berliner Philharmoniker & Herbert Von Karajan" },
                new Artist { Name = "Billy Cobham" },
                new Artist { Name = "Black Label Society" },
                new Artist { Name = "Black Sabbath" },
                new Artist { Name = "Boston Symphony Orchestra & Seiji Ozawa" },
                new Artist { Name = "Britten Sinfonia, Ivor Bolton & Lesley Garrett" },
                new Artist { Name = "Bruce Dickinson" },
                new Artist { Name = "Buddy Guy" },
                new Artist { Name = "Caetano Veloso" },
                new Artist { Name = "Cake" },
                new Artist { Name = "Calexico" },
                new Artist { Name = "Cássia Eller" },
                new Artist { Name = "Chic" },
                new Artist { Name = "Chicago Symphony Orchestra & Fritz Reiner" },
                new Artist { Name = "Chico Buarque" },
                new Artist { Name = "Chico Science & Nação Zumbi" },
                new Artist { Name = "Choir Of Westminster Abbey & Simon Preston" },
                new Artist { Name = "Chris Cornell" },
                new Artist { Name = "Christopher O'Riley" },
                new Artist { Name = "Cidade Negra" },
                new Artist { Name = "Cláudio Zoli" },
                new Artist { Name = "Creedence Clearwater Revival" },
                new Artist { Name = "David Coverdale" },
                new Artist { Name = "Deep Purple" },
                new Artist { Name = "Dennis Chambers" },
                new Artist { Name = "Djavan" },
                new Artist { Name = "Donna Summer" },
                new Artist { Name = "Dread Zeppelin" },
                new Artist { Name = "Ed Motta" },
                new Artist { Name = "Edo de Waart & San Francisco Symphony" },
                new Artist { Name = "Elis Regina" },
                new Artist { Name = "English Concert & Trevor Pinnock" },
                new Artist { Name = "Eric Clapton" },
                new Artist { Name = "Eugene Ormandy" },
                new Artist { Name = "Faith No More" },
                new Artist { Name = "Falamansa" },
                new Artist { Name = "Foo Fighters" },
                new Artist { Name = "Frank Zappa & Captain Beefheart" },
                new Artist { Name = "Fretwork" },
                new Artist { Name = "Funk Como Le Gusta" },
                new Artist { Name = "Gerald Moore" },
                new Artist { Name = "Gilberto Gil" },
                new Artist { Name = "Godsmack" },
                new Artist { Name = "Gonzaguinha" },
                new Artist { Name = "Göteborgs Symfoniker & Neeme Järvi" },
                new Artist { Name = "Guns N' Roses" },
                new Artist { Name = "Gustav Mahler" },
                new Artist { Name = "Incognito" },
                new Artist { Name = "Iron Maiden" },
                new Artist { Name = "James Levine" },
                new Artist { Name = "Jamiroquai" },
                new Artist { Name = "Jimi Hendrix" },
                new Artist { Name = "Joe Satriani" },
                new Artist { Name = "Jorge Ben" },
                new Artist { Name = "Jota Quest" },
                new Artist { Name = "Judas Priest" },
                new Artist { Name = "Julian Bream" },
                new Artist { Name = "Kent Nagano and Orchestre de l'Opéra de Lyon" },
                new Artist { Name = "Kiss" },
                new Artist { Name = "Led Zeppelin" },
                new Artist { Name = "Legião Urbana" },
                new Artist { Name = "Lenny Kravitz" },
                new Artist { Name = "Les Arts Florissants & William Christie" },
                new Artist { Name = "London Symphony Orchestra & Sir Charles Mackerras" },
                new Artist { Name = "Luciana Souza/Romero Lubambo" },
                new Artist { Name = "Lulu Santos" },
                new Artist { Name = "Marcos Valle" },
                new Artist { Name = "Marillion" },
                new Artist { Name = "Marisa Monte" },
                new Artist { Name = "Martin Roscoe" },
                new Artist { Name = "Maurizio Pollini" },
                new Artist { Name = "Mela Tenenbaum, Pro Musica Prague & Richard Kapp" },
                new Artist { Name = "Men At Work" },
                new Artist { Name = "Metallica" },
                new Artist { Name = "Michael Tilson Thomas & San Francisco Symphony" },
                new Artist { Name = "Miles Davis" },
                new Artist { Name = "Milton Nascimento" },
                new Artist { Name = "Mötley Crüe" },
                new Artist { Name = "Motörhead" },
                new Artist { Name = "Nash Ensemble" },
                new Artist { Name = "Nicolaus Esterhazy Sinfonia" },
                new Artist { Name = "Nirvana" },
                new Artist { Name = "O Terço" },
                new Artist { Name = "Olodum" },
                new Artist { Name = "Orchestra of The Age of Enlightenment" },
                new Artist { Name = "Os Paralamas Do Sucesso" },
                new Artist { Name = "Ozzy Osbourne" },
                new Artist { Name = "Page & Plant" },
                new Artist { Name = "Paul D'Ianno" },
                new Artist { Name = "Pearl Jam" },
                new Artist { Name = "Pink Floyd" },
                new Artist { Name = "Queen" },
                new Artist { Name = "R.E.M." },
                new Artist { Name = "Raul Seixas" },
                new Artist { Name = "Red Hot Chili Peppers" },
                new Artist { Name = "Roger Norrington, London Classical Players" },
                new Artist { Name = "Royal Philharmonic Orchestra & Sir Thomas Beecham" },
                new Artist { Name = "Rush" },
                new Artist { Name = "Santana" },
                new Artist { Name = "Scholars Baroque Ensemble" },
                new Artist { Name = "Scorpions" },
                new Artist { Name = "Sergei Prokofiev & Yuri Temirkanov" },
                new Artist { Name = "Sir Georg Solti & Wiener Philharmoniker" },
                new Artist { Name = "Skank" },
                new Artist { Name = "Soundgarden" },
                new Artist { Name = "Spyro Gyra" },
                new Artist { Name = "Stevie Ray Vaughan & Double Trouble" },
                new Artist { Name = "Stone Temple Pilots" },
                new Artist { Name = "System Of A Down" },
                new Artist { Name = "Temple of the Dog" },
                new Artist { Name = "Terry Bozzio, Tony Levin & Steve Stevens" },
                new Artist { Name = "The 12 Cellists of The Berlin Philharmonic" },
                new Artist { Name = "The Black Crowes" },
                new Artist { Name = "The Cult" },
                new Artist { Name = "The Doors" },
                new Artist { Name = "The King's Singers" },
                new Artist { Name = "The Police" },
                new Artist { Name = "The Posies" },
                new Artist { Name = "The Rolling Stones" },
                new Artist { Name = "The Who" },
                new Artist { Name = "Tim Maia" },
                new Artist { Name = "Ton Koopman" },
                new Artist { Name = "U2" },
                new Artist { Name = "UB40" },
                new Artist { Name = "Van Halen" },
                new Artist { Name = "Various Artists" },
                new Artist { Name = "Velvet Revolver" },
                new Artist { Name = "Vinícius De Moraes" },
                new Artist { Name = "Wilhelm Kempff" },
                new Artist { Name = "Yehudi Menuhin" },
                new Artist { Name = "Yo-Yo Ma" },
                new Artist { Name = "Zeca Pagodinho" }
            };

                //context'e gidip context içerisindeki genres tablosuna yukarıdaki verileri ekle.

                foreach (var item in artists)
                {
                    musicStoreContext.Artist.Add(item);
                    musicStoreContext.SaveChanges();
                }
            }
        }


        //AddAlbums
        public void AddAlbums()
        {
            if (musicStoreContext.Albums.ToList().Count == 0)
            {
                var liste = new List<Album>
                {
                    new Album { Title = "The Best Of Men At Work", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Men At Work"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "A Copland Celebration, Vol. I", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Aaron Copland & London Symphony Orchestra"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Worlds", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "For Those About To Rock We Salute You", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Let There Be Rock", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Balls to the Wall", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Accept"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Restless and Wild", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Accept"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Górecki: Symphony No. 3", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Adrian Leaper & Doreen de Feis"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Big Ones", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Aerosmith"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Quiet Songs", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Aisha Duo"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Jagged Little Pill", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Alanis Morissette"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Facelift", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Alice In Chains"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Frank", Genre = musicStoreContext.Genres.Single(g => g.Name == "Pop"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Amy Winehouse"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Ring My Bell", Genre = musicStoreContext.Genres.Single(g => g.Name == "Disco"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Anita Ward"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Chill: Brazil (Disc 2)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Antônio Carlos Jobim"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Warner 25 Anos", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Antônio Carlos Jobim"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Plays Metallica By Four Cellos", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Apocalyptica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Revelations", Genre = musicStoreContext.Genres.Single(g => g.Name == "Alternative"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Audioslave"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Audioslave", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Audioslave"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Last Night of the Proms", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Barry Wordsworth & BBC Concert Orchestra"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Sibelius: Finlandia", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Berliner Philharmoniker & Hans Rosbaud"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Mozart: Symphonies Nos. 40 & 41", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Berliner Philharmoniker & Herbert Von Karajan"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Best Of Billy Cobham", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Billy Cobham"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Alcohol Fueled Brewtality Live! [Disc 1]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Black Label Society"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Alcohol Fueled Brewtality Live! [Disc 2]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Black Label Society"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Black Sabbath Vol. 4 (Remaster)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Black Sabbath"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Black Sabbath", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Black Sabbath"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Carmina Burana", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Boston Symphony Orchestra & Seiji Ozawa"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "A Soprano Inspired", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Britten Sinfonia, Ivor Bolton & Lesley Garrett"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Chemical Wedding", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Bruce Dickinson"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Prenda Minha", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Caetano Veloso"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Sozinho Remix Ao Vivo", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Caetano Veloso"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Cake: B-Sides and Rarities", Genre = musicStoreContext.Genres.Single(g => g.Name == "Alternative"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Cake"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Carried to Dust (Bonus Track Version)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Alternative"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Calexico"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Cássia Eller - Sem Limite [Disc 1]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Cássia Eller"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Le Freak", Genre = musicStoreContext.Genres.Single(g => g.Name == "Disco"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Chic"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Scheherazade", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Chicago Symphony Orchestra & Fritz Reiner"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Minha Historia", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Chico Buarque"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Afrociberdelia", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Chico Science & Nação Zumbi"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Da Lama Ao Caos", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Chico Science & Nação Zumbi"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Carry On", Genre = musicStoreContext.Genres.Single(g => g.Name == "Alternative"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Chris Cornell"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "SCRIABIN: Vers la flamme", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Christopher O'Riley"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Acústico MTV [Live]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Reggae"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Cidade Negra"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Cidade Negra - Hits", Genre = musicStoreContext.Genres.Single(g => g.Name == "Reggae"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Cidade Negra"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Na Pista", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Cláudio Zoli"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Chronicle, Vol. 1", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Creedence Clearwater Revival"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Chronicle, Vol. 2", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Creedence Clearwater Revival"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Into The Light", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "David Coverdale"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Come Taste The Band", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Deep Purple In Rock", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Fireball", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Machine Head", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "MK III The Final Concerts [Disc 1]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Purpendicular", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Slaves And Masters", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Stormbringer", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Battle Rages On", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Final Concerts (Disc 2)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Outbreak", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Dennis Chambers"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Djavan Ao Vivo - Vol. 02", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Djavan"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Djavan Ao Vivo - Vol. 1", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Djavan"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "MacArthur Park Suite", Genre = musicStoreContext.Genres.Single(g => g.Name == "Disco"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Donna Summer"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Un-Led-Ed", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Dread Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Best of Ed Motta", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Ed Motta"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Adams, John: The Chairman Dances", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Edo de Waart & San Francisco Symphony"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Elis Regina-Minha História", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Elis Regina"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Pachelbel: Canon & Gigue", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "English Concert & Trevor Pinnock"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Unplugged", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Eric Clapton"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Cream Of Clapton", Genre = musicStoreContext.Genres.Single(g => g.Name == "Blues"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Eric Clapton"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Unplugged", Genre = musicStoreContext.Genres.Single(g => g.Name == "Blues"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Eric Clapton"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Respighi:Pines of Rome", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Eugene Ormandy"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Strauss: Waltzes", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Eugene Ormandy"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "King For A Day Fool For A Lifetime", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Faith No More"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Deixa Entrar", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Falamansa"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "In Your Honor [Disc 1]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Foo Fighters"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "In Your Honor [Disc 2]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Foo Fighters"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Colour And The Shape", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Foo Fighters"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Bongo Fury", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Frank Zappa & Captain Beefheart"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Roda De Funk", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Funk Como Le Gusta"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Quanta Gente Veio Ver (Live)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Gilberto Gil"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Quanta Gente Veio ver--Bônus De Carnaval", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Gilberto Gil"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Faceless", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Godsmack"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Meus Momentos", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Gonzaguinha"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Nielsen: The Six Symphonies", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Göteborgs Symfoniker & Neeme Järvi"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Appetite for Destruction", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Guns N' Roses"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Use Your Illusion I", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Guns N' Roses"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Use Your Illusion II", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Guns N' Roses"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Blue Moods", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Incognito"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "A Matter of Life and Death", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Brave New World", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Fear Of The Dark", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Live At Donington 1992 (Disc 1)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Live At Donington 1992 (Disc 2)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Rock In Rio [CD2]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Number of The Beast", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The X Factor", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Virtual XI", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "A Real Dead One", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "A Real Live One", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Live After Death", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "No Prayer For The Dying", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Piece Of Mind", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Powerslave", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Rock In Rio [CD1]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Rock In Rio [CD2]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Seventh Son of a Seventh Son", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Somewhere in Time", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Number of The Beast", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Iron Maiden", Genre = musicStoreContext.Genres.Single(g => g.Name == "Blues"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Mascagni: Cavalleria Rusticana", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "James Levine"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },

                    new Album { Title = "Emergency On Planet Earth", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Jamiroquai"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Are You Experienced?", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Jimi Hendrix"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Surfing with the Alien (Remastered)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Joe Satriani"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Jorge Ben Jor 25 Anos", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Jorge Ben"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Jota Quest-1995", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Jota Quest"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Living After Midnight", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Judas Priest"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Weill: The Seven Deadly Sins", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Kent Nagano and Orchestre de l'Opéra de Lyon"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Greatest Kiss", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Kiss"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Unplugged [Live]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Kiss"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "BBC Sessions [Disc 1] [Live]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "BBC Sessions [Disc 2] [Live]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Coda", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Houses Of The Holy", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "In Through The Out Door", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "IV", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Led Zeppelin I", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Led Zeppelin II", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Led Zeppelin III", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Physical Graffiti [Disc 1]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Physical Graffiti [Disc 2]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Presence", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Song Remains The Same (Disc 1)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Song Remains The Same (Disc 2)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Mais Do Mesmo", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Legião Urbana"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Greatest Hits", Genre = musicStoreContext.Genres.Single(g => g.Name == "Reggae"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Lenny Kravitz"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Greatest Hits", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Lenny Kravitz"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Greatest Hits", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Lenny Kravitz"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Tchaikovsky: The Nutcracker", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "London Symphony Orchestra & Sir Charles Mackerras"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Duos II", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Luciana Souza/Romero Lubambo"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Chill: Brazil (Disc 1)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Marcos Valle"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Misplaced Childhood", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Marillion"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Barulhinho Bom", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Marisa Monte"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Szymanowski: Piano Works, Vol. 1", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Martin Roscoe"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "...And Justice For All", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Metallica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Black Album", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Metallica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Garage Inc. (Disc 1)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Metallica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Garage Inc. (Disc 2)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Metallica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Load", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Metallica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Master Of Puppets", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Metallica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "ReLoad", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Metallica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Ride The Lightning", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Metallica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "St. Anger", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Metallica"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Berlioz: Symphonie Fantastique", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Michael Tilson Thomas & San Francisco Symphony"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Prokofiev: Romeo & Juliet", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Michael Tilson Thomas & San Francisco Symphony"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Miles Ahead", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Miles Davis"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Essential Miles Davis [Disc 1]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Miles Davis"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Essential Miles Davis [Disc 2]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Miles Davis"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Milton Nascimento Ao Vivo", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Milton Nascimento"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Minas", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Milton Nascimento"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Motley Crue Greatest Hits", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Mötley Crüe"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Ace Of Spades", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Motörhead"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Mozart: Chamber Music", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Nash Ensemble"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Best of Beethoven", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Nicolaus Esterhazy Sinfonia"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Nevermind", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Nirvana"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Compositores", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "O Terço"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Olodum", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Olodum"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Bach: The Brandenburg Concertos", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Orchestra of The Age of Enlightenment"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Acústico MTV", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Os Paralamas Do Sucesso"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Arquivo II", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Os Paralamas Do Sucesso"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },


                    new Album { Title = "Arquivo Os Paralamas Do Sucesso", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Os Paralamas Do Sucesso"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Tribute", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Bark at the Moon (Remastered)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Blizzard of Ozz", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Diary of a Madman (Remastered)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "No More Tears (Remastered)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Speak of the Devil", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Walking Into Clarksdale", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Page & Plant"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Beast Live", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Paul D'Ianno"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Live On Two Legs [Live]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Pearl Jam"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Riot Act", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Pearl Jam"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Ten", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Pearl Jam"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Vs.", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Pearl Jam"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Dark Side Of The Moon", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Pink Floyd"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Greatest Hits I", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Queen"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Greatest Hits II", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Queen"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "News Of The World", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Queen"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "New Adventures In Hi-Fi", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "R.E.M."), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Raul Seixas", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Raul Seixas"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "By The Way", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Red Hot Chili Peppers"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Californication", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Red Hot Chili Peppers"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Purcell: The Fairy Queen", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Roger Norrington, London Classical Players"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Haydn: Symphonies 99 - 104", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Royal Philharmonic Orchestra & Sir Thomas Beecham"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Retrospective I (1974-1980)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Rush"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Santana - As Years Go By", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Santana"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Santana Live", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Santana"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Supernatural", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Santana"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Handel: The Messiah (Highlights)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Scholars Baroque Ensemble"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Prokofiev: Symphony No.1", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Sergei Prokofiev & Yuri Temirkanov"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Wagner: Favourite Overtures", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Sir Georg Solti & Wiener Philharmoniker"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Maquinarama", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Skank"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "O Samba Poconé", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Skank"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "A-Sides", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Soundgarden"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Heart of the Night", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Spyro Gyra"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Morning Dance", Genre = musicStoreContext.Genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Spyro Gyra"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "In Step", Genre = musicStoreContext.Genres.Single(g => g.Name == "Blues"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Stevie Ray Vaughan & Double Trouble"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Core", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Stone Temple Pilots"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Mezmerize", Genre = musicStoreContext.Genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "System Of A Down"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Temple of the Dog", Genre = musicStoreContext.Genres.Single(g => g.Name == "Alternative"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Temple of the Dog"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "[1997] Black Light Syndrome", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Terry Bozzio, Tony Levin & Steve Stevens"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "South American Getaway", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The 12 Cellists of The Berlin Philharmonic"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Live [Disc 1]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Blues"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Black Crowes"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Live [Disc 2]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Blues"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Black Crowes"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Beyond Good And Evil", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Cult"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Doors", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Doors"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },


                    new Album { Title = "English Renaissance", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The King's Singers"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Police Greatest Hits", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Police"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Every Kind of Light", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Posies"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Hot Rocks, 1964-1971 (Disc 1)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Rolling Stones"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "No Security", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Rolling Stones"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Voodoo Lounge", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Rolling Stones"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "My Generation - The Very Best Of The Who", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "The Who"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Serie Sem Limite (Disc 1)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Tim Maia"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Serie Sem Limite (Disc 2)", Genre = musicStoreContext.Genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Tim Maia"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Bach: Toccata & Fugue in D Minor", Genre = musicStoreContext.Genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Ton Koopman"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Achtung Baby", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "U2"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "B-Sides 1980-1990", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "U2"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "How To Dismantle An Atomic Bomb", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "U2"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Pop", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "U2"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Rattle And Hum", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "U2"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Best Of 1980-1990", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "U2"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "War", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "U2"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Zooropa", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "U2"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "UB40 The Best Of - Volume Two [UK]", Genre = musicStoreContext.Genres.Single(g => g.Name == "Reggae"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "UB40"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Diver Down", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Van Halen"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "The Best Of Van Halen, Vol. I", Genre = musicStoreContext.Genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artist.Single(a => a.Name == "Van Halen"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },                
                    
                    /*
                    new Album { Title = "Van Halen III", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Van Halen"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Van Halen", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Van Halen"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    /*
                    new Album { Title = "Axé Bahia 2001",
                        Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Pop"), 
                        Price = 8.99M, 
                        Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Various musicStoreContext.Artists"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Sambas De Enredo 2001", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Various musicStoreContext.Artists"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Vozes do MPB", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Various musicStoreContext.Artists"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Contraband", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Rock"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Velvet Revolver"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Vinicius De Moraes", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Vinícius De Moraes"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    /*
                    new Album { Title = "Bach: Goldberg Variations", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Wilhelm Kempff"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Bartok: Violin & Viola Concertos", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Yehudi Menuhin"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Bach: The Cello Suites", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Classical"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Yo-Yo Ma"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                    new Album { Title = "Ao Vivo [IMPORT]", Genre = musicStoreContext.Genres.FirstOrDefault(g => g.Name == "Latin"), Price = 8.99M, Artist = musicStoreContext.Artists.FirstOrDefault(a => a.Name == "Zeca Pagodinho"), AlbumArtUrl = "~/assets/images/placeholder.jpg" },
                  */
                };

                foreach (var item in liste)
                {
                    musicStoreContext.Albums.Add(item);
                    musicStoreContext.SaveChanges();
                }
            }
        }
    }
}
