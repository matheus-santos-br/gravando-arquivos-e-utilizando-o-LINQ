using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Arquivos_e_LINQ.Models
{
    public class LivrosFavoritos
    {
        public List<Livros> Livros { get; set; }
        public LivrosFavoritos()
        {
            Livros = new List<Livros>();
        }
        public void Add(Livros livro)
        {
            Livros.Add(livro);
        }
        public void Show()
        {
            Console.WriteLine("Livros favoritos: ");
            foreach(var aux in Livros)
            {
                Console.WriteLine($@"{aux.titulo} - {aux.autor}");
            }

            Console.WriteLine();
        }
        public void Extrair()
        {
            string json = JsonSerializer.Serialize(new
            {
                livros = Livros
            });

            string diretorio = "C:\\dev\\C# consumindo API, gravando arquivos e utilizando o LINQ\\gravando-arquivos-e-utilizando-o-LINQ\\Arquivos_e_LINQ\\livrosFavoritos.json";

            File.WriteAllText(diretorio,json);
            Console.WriteLine($@"Arquivo {diretorio} criado com sucesso!");
        }
    }
}
