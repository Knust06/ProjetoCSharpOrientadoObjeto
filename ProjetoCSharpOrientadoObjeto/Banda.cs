class Banda
{
    private List<Album> albums = new List<Album>();
    public string Name { get;}

    public Banda(string name)
    {
        Name = name;
    }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowDiscograph()
    {
        Console.WriteLine($"Showing discograph of band {Name}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Album:{album.Name} ({album.TotalDuration})");
        }
    }
}

