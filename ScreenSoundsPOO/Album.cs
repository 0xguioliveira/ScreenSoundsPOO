class Album
{

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao); // para cada música, Some a duração.

    private List<Musica> musicas = new List<Musica>();

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Esse álbum possui a duração de {DuracaoTotal}");
    }
    
}
