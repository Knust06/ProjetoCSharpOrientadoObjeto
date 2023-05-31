class Music
{
    public string name;
    public string artist;
    public int duration;
    public bool available;

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