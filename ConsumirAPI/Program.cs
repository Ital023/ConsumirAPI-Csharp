using System.Net.Http.Json;
using System.Text.Json;
using ConsumirAPI.Modelos;

using (HttpClient client = new HttpClient())
{

    try
    {
        string reposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(reposta);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(reposta);

        

    }catch (Exception ex)
    {
        Console.WriteLine("O programa não rodou pois: "+ ex.Message);
    }




    
}
