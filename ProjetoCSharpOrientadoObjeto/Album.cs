class Album
{
    public string name { get; set; }

    private List<Music> musics = new List<Music>();
    public int TotalDuration { get; }
    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

}