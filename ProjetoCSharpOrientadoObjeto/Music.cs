class Music
{
    public string name;
    public string artist;
    public int duration;
    private bool available;

    public void WriteAvailable(bool value)
    {
        available = value;
    }

    public bool ReadAvailable()
    {
        return available;
    }

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
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Duration: {duration}");        
        if (available)
        {
            Console.WriteLine("Available in the plan");
        } 
        else
        {
            Console.WriteLine("Pick other plan more expansive");
        }

    }
}