class Banda
{
    private List<Album> albuns= new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);

    }
    public void ExibindoDiscografia()
    {
        Console.WriteLine($"\nExibindo discografia da banda {Nome}");
        foreach(Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome}, duração: {album.DuracaoTotal}");
        }
    }
}