using System.Net.Http.Json;
using System.Text.Json;
using ConsumirAPI.Modelos;
using ConsumirAPI.Filtros;


using (HttpClient client = new HttpClient())
{

    try
    {
        string reposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(reposta);

        var musicasFavoritasDoItalo = new MusicasPreferidas("Italo");
        musicasFavoritasDoItalo.AddMusicaPreferida(musicas[980]);
        musicasFavoritasDoItalo.AddMusicaPreferida(musicas[513]);
        musicasFavoritasDoItalo.AddMusicaPreferida(musicas[1024]);
        musicasFavoritasDoItalo.AddMusicaPreferida(musicas[999]);
        musicasFavoritasDoItalo.AddMusicaPreferida(musicas[37]);

        musicasFavoritasDoItalo.ExibirMusicasPreferidas();

        musicasFavoritasDoItalo.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine("O programa não rodou pois: "+ ex.Message);
       
    }


    //LinqFilter.FiltrarGenerosMusicais(musicas);

    //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

    //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas,"pop");

    //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Rihanna");

    //LinqFilter.FiltrarMusicasPorAno(musicas, "2019");

    //Console.WriteLine(reposta);
    /*foreach(var musica in musicas)
    {
        musica.exibirDetalhes();
    }*/
}
