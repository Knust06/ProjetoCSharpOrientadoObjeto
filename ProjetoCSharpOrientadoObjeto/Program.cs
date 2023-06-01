// Beginning of the studies about object in c#
//App de musica que precisa ter name / artist / duration / available

Music music1 = new Music();
music1.name = "Máscaras";
music1.artist = "Shiny_sz";
music1.duration = 280;
music1.WriteAvailable(true);
Console.WriteLine(music1.ReadAvailable());



//Console.WriteLine($"Nome da música {musica1}")It is show for default the type of object when you dont define.

Music music2 = new Music();
music2.name = "Chainsaw Man";
music2.artist = "VMZ";
music2.duration = 300;
music2.WriteAvailable(false);
Console.WriteLine(music2.ReadAvailable());

music1.ShowTechnicalForm();
music2.ShowTechnicalForm();



