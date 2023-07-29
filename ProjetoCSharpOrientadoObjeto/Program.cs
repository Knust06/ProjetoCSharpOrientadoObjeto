//Banda Shaw_Mendes = new Banda("Shaw_Mendes");
//
//Album albumOfShawn = new Album("Illuminate");
//
//Music music1 = new Music(Shaw_Mendes, "Mercy")
//{
//    Duration = 190,
//    Available = false
//};
//Music music2 = new Music(Shaw_Mendes, "There is nothing holding me back")
//{
//    Duration = 300,
//    Available = true
//};
//
//albumOfShawn.AddMusic(music1);
//albumOfShawn.AddMusic(music2);
//albumOfShawn.ShowAlbumMusics();
//Shaw_Mendes.AddAlbum(albumOfShawn);
//Shaw_Mendes.ShowDiscograph();
//
//music1.ShowTechnicalForm();
//music2.ShowTechnicalForm();

Episode ep1 = new(2, "Facility Tecnique", 45);
ep1.AddGuest("Knust");
ep1.AddGuest("Isabella");

Episode ep2 = new(1, "New creating content", 32);
ep2.AddGuest("Thiago");
ep2.AddGuest("Lobo");

Podcast podcast = new("New podcast", "Daniel");
podcast.AddEpisode(ep1);
podcast.AddEpisode(ep2);
podcast.ShowDetails();

