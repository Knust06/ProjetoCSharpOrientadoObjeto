// Beginning of the studies about object in c#
//App de musica que precisa ter name / artist / duration / available

Music music1 = new Music();
music1.Name = "Máscaras";
music1.Artist = "Shiny_sz";
music1.Duration = 280;
music1.Available = true;
Console.WriteLine(music1.Showcase);



//Console.WriteLine($"Nome da música {musica1}")It is show for default the type of object when you dont define.

Music music2 = new Music();
music2.Name = "Chainsaw Man";
music2.Artist = "VMZ";
music2.Duration = 300;
music2.Available = false;
Console.WriteLine(music2.Showcase);

music1.ShowTechnicalForm();
music2.ShowTechnicalForm();



