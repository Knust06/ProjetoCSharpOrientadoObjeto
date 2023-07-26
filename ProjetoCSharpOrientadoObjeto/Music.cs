class Music
{
    public Music(Banda artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; } //Ctrl + r make the rename in ALL files that uses this name
    public Banda Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string Showcase => $"The music {Name} was created by the artist {Artist}.";

    //Fields/Atributes/Variable only store a value
    //Property define how can acess and change this value

    //prop + Tab complete like ! in VS Code for HTML


    // public void WriteAvailable(bool value) //(SET) Have an operation of writting 
    // {
    //     available = value;
    // }

    // public bool ReadAvailable() //(GET) Have an operation of reading 
    // {
    //     return available;
    // }

    // This was just a test for studies, please ignore
    //public bool CheckIsAvailable(bool vale)
    //{
    //    if (available) { 
    //        available = vale;
    //    }
    //    else
    //    {
    //        available = vale;
    //    }
    //    return vale;
    //
    //}

    public void ShowTechnicalForm()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");        
        if (Available)
        {
            Console.WriteLine("Available in the plan");
        } 
        else
        {
            Console.WriteLine("Pick other plan more expansive");
        }

    }
}