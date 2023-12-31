﻿using System.Text.Json.Serialization;
namespace ConsumirAPI.Modelos;
class Musica
{
    [JsonPropertyName("song")]
    public string Nome { get; set; }

    [JsonPropertyName("artist")]
    public string Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string Genero { get; set; }

    [JsonPropertyName("year")]
    public string ano { get; set; }



    public void exibirDetalhes()
    {
        Console.WriteLine("Musica: " + Nome);
        Console.WriteLine("Artista: " + Artista);
        Console.WriteLine("Duração: " + Duracao / 1000);
        Console.WriteLine("Genero: " + Genero);
        Console.WriteLine("Ano: " + ano);

    }

    public void exibirGenerosMusicais(List<Musica> musicas)
    {
        foreach(var musica in musicas)
        {
            Console.WriteLine(musica.Genero);
        }
    }




}