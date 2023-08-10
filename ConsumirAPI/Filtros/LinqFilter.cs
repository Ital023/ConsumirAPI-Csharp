using ConsumirAPI.Modelos;
namespace ConsumirAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas,string genero)
    {
        var artistaPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero))
            .Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo artistas por genero musical >>>> {genero}");

        foreach(var artista in  artistaPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();

        Console.WriteLine(nomeDoArtista);

        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas,string ano)
    {
        var musicaPorAno = musicas.Where(musica => musica.ano.Equals(ano)).ToList();

        Console.WriteLine(ano);

        foreach(var musica in musicaPorAno)
        {
            Console.WriteLine($"A musica: {musica.Nome} e o ano: {musica.ano}");
        }
    }

}
