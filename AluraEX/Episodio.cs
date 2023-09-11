namespace AluraEX;

public class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, int duracao, string titulo)
    {
        this.Ordem = ordem;
        this.Duracao = duracao;
        this.Titulo = titulo;

    }
    public int Ordem { get; }
    public string Titulo { get; }

    public int Duracao { get; }

    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}
