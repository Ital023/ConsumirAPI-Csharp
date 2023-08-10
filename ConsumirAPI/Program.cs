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

        LinqFilter.FiltrarGenerosMusicais(musicas);

    }
    catch (Exception ex)
    {
        Console.WriteLine("O programa não rodou pois: "+ ex.Message);
        //Console.WriteLine(reposta);
        /*foreach(var musica in musicas)
        {
            musica.exibirDetalhes();
        }*/
    }
}
