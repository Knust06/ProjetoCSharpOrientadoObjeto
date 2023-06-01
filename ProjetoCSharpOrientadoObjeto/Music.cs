class Music
{
    public string Name { get; set; } //Ctrl + r make the rename in ALL files that uses this name
    public string Artist { get; set; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string Showcase 
    { 
        get
        {
            return $"The music {Name} was created by the artist {Artist}.";
        }
    } 
    
    
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
        Console.WriteLine($"Artist: {Artist}");
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