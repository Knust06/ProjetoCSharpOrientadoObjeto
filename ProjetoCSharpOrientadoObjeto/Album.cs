class Album
{
    public string Name { get; set; }

    private List<Music> Musics = new List<Music>();
    public int TotalDuration => Musics.Sum(Music => Music.Duration);
    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }
    public void ShowAlbumMusics()
    {
        Console.WriteLine($"List of musics in album {Name}\n");
        foreach (Music music in Musics)
        {            
            Console.WriteLine($"Music: {music.Name}");            
        }
        Console.WriteLine($"Total duration of this album is: {TotalDuration}");
    }

}