using ConsumirAPI.Modelos;
namespace ConsumirAPI.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistaOrdenados = musicas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista).Distinct().ToList();

        foreach(var artista in artistaOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }

    }

}
