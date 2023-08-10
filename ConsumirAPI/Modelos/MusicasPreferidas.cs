using System.Text.Json;

namespace ConsumirAPI.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasPreferidas = new List<Musica>();
    }

    public void AddMusicaPreferida(Musica musica)
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    public void ExibirMusicasPreferidas()
    {
        Console.WriteLine($"Essas são as musicas preferidas -> {Nome}");
        foreach(var musica in ListaDeMusicasPreferidas)
        {
            Console.WriteLine($"- {musica.Nome} do {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasPreferidas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
