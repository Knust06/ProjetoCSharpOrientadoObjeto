Album albumOfShawn = new Album();
albumOfShawn.Name = "Illuminate";

Music music1 = new Music();
music1.Name = "Mercy";
music1.Duration = 190;

Music music2 = new Music();
music2.Name = "There is nothing holding me back";
music2.Duration = 200;

albumOfShawn.AddMusic(music1);
albumOfShawn.AddMusic(music2);

albumOfShawn.ShowAlbumMusics();



