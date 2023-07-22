class Album
{
    public string Name { get; set; }

    private List<Music> musics = new List<Music>();
    public int TotalDuration => musics.Sum(Music => Music.Duration);
    public void AddMusic(Music music)
    {
        musics.Add(music);
    }
    public void ShowAlbumMusics()
    {
        Console.WriteLine($"List of musics in album {Name}\n");
        foreach (Music music in musics)
        {            
            Console.WriteLine($"Music: {music.Name}");            
        }
        Console.WriteLine($"Total duration of this album is: {TotalDuration}");
    }

}