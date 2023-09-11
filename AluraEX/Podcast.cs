namespace AluraEX;

public class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string nome, string host)
    {
        this.Nome = nome;
        this.host = host;

    }
    public string Nome { get; }

    public string host { get; }

    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio ep)
    {
        episodios.Add(ep);
    }

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Podcast {Nome}, apresentado por {host} \n");
        foreach(Episodio ep in episodios.OrderBy(e => e.Ordem))
        {
            System.Console.WriteLine(ep.Resumo);
        }
        System.Console.WriteLine($"\n\n Este podcast possui {TotalEpisodios} de episodios.");
    }
}
