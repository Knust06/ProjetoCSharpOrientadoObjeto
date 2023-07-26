Banda Shaw_Mendes = new Banda("Shaw_Mendes");

Album albumOfShawn = new Album("Illuminate");

Music music1 = new Music(Shaw_Mendes, "Mercy")
{
    Duration = 190,
    Available = false
};
Music music2 = new Music(Shaw_Mendes, "There is nothing holding me back")
{
    Duration = 300,
    Available = true
};

albumOfShawn.AddMusic(music1);
albumOfShawn.AddMusic(music2);
albumOfShawn.ShowAlbumMusics();
Shaw_Mendes.AddAlbum(albumOfShawn);
Shaw_Mendes.ShowDiscograph();

music1.ShowTechnicalForm();
music2.ShowTechnicalForm();



