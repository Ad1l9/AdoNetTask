using AdoNetTask.Models;
using AdoNetTask.Services;

ArtistService artistService = new ArtistService();
Artist artist = new Artist()
{
    Name = "Adil",
    Surname = "Nasirli",
    Birthday = DateTime.Now,
    Gender = "Male"
};
//artistService.Create(artist);



artistService.Delete(7);

List<Artist> artists = artistService.GetAll();


foreach (Artist item in artists)
{
    Console.WriteLine(item);
}

//Artist artist1 = artistService.GetById(2);
//Console.WriteLine(artist);

//MusicService ms = new MusicService();
//Music music = new Music()
//{
//    Name = "Leyla",
//    Duration = 1000,
//    IsDeleted = false,
//};
//ms.Create(music);
//ms.Delete(1);

//List<Music> musics = ms.GetAll();


//foreach (Music musicc in musics)
//{
//    Console.WriteLine(musicc);
//}