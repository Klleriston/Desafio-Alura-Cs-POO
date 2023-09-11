using AluraEX;

Episodio ep1 = new Episodio(1, 45, "Técnicas Jujutsu");
ep1.AdicionarConvidados("Gojou");
ep1.AdicionarConvidados("Sukuna");
ep1.AdicionarConvidados("Yuuta");
//System.Console.WriteLine(ep1.Resumo);

Episodio ep2 = new Episodio(2, 90, "Como conquistar o ONE PIECE");
ep2.AdicionarConvidados("Monkey D. Luffy");
ep2.AdicionarConvidados("trafalgar d law");
ep2.AdicionarConvidados("Eustass Kid");
//System.Console.WriteLine(ep2.Resumo);

Podcast podcast = new("'Crunchy Podcast'", "Klleriston");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();


