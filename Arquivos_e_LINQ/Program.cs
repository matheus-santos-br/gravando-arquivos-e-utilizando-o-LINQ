using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Arquivos_e_LINQ;
using Arquivos_e_LINQ.Filters;
using Arquivos_e_LINQ.Models;

public class Program
{
    public static void Main(string[] args)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            Uri url = new Uri("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = url;
            request.Method = HttpMethod.Get;

            try
            {
                HttpResponseMessage response = httpClient.SendAsync(request).Result;
                string retorno = response.Content.ReadAsStringAsync().Result;

                List<Livros> livros = JsonSerializer.Deserialize<List<Livros>>(retorno);

                Exemplos exe = new Exemplos();

                //Usando LINQ
                exe.UsandoLinq(livros);

                //Extraindo um arquivo .json
                exe.MostrarLivrosFavoritos(livros);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}