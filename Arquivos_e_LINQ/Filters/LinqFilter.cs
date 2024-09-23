using Arquivos_e_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_e_LINQ.Filters
{
    public class LinqFilter
    {
        public static void Filter(List<Livros> livros)
        {
            List<string> all = livros.Select(livro => livro.titulo).Distinct().ToList();

            Console.WriteLine("Lista: ");
            foreach (var aux in all)
            {
                Console.WriteLine($@"Título: {aux}");
            }

            Console.WriteLine();
        }
        public static void FilterByGenre(List<Livros> livros, string genero)
        {
            List<string> byGenre = livros.Where(livro => livro.genero.Contains(genero))
                                                .Select(livro => livro.autor)
                                                .Distinct()
                                                .ToList();

            Console.WriteLine($@"Autor por gênero: ");
            foreach (var aux in byGenre)
            {
                Console.WriteLine($@"Autor: {aux}");
            }

            Console.WriteLine();
        }
        public static void FilterByAuthor(List<Livros> livros, string autor)
        {
            List<Livros> byAuthor = livros.Where(livro => livro.autor!.Equals(autor)).ToList();

            Console.WriteLine($@"Livro por Autor ({autor}): ");

            LinqOrder.Order(byAuthor);
        }
    }
}
