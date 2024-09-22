using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
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

                LinqFilter.Filter(livros);

                Console.WriteLine();

                Console.WriteLine("Lista Ordenada: ");
                LinqOrder.Order(livros);

                Console.WriteLine();

                LinqFilter.FilterByGenre(livros, "Ficção Científica");
                Console.WriteLine();
                LinqFilter.FilterByGenre(livros, "Fantasia");

                Console.WriteLine();

                LinqFilter.FilterByAuthor(livros, "J.R.R. Tolkien");
                Console.WriteLine();
                LinqFilter.FilterByAuthor(livros, "George Orwell");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}