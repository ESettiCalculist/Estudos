Episodio ep1 = new(1, "Tecnicas de coisas", 45);
ep1.AdicionarConvidados("Maria");

Episodio ep2 = new(2, "Tecnicas de seila", 85);
ep2.AdicionarConvidados("Joao");

Podcast podcast = new("Flow", "igao");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();