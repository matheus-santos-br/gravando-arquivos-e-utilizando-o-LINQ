using Arquivos_e_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_e_LINQ.Filters
{
    public class LinqOrder
    {
        public static void Order(List<Livros> livros)
        {
            List<string> orderedList = livros.OrderBy(livro =>
                                              livro.titulo)
                                              .Select(livro => livro.titulo)
                                              .Distinct().ToList();

            foreach (var aux in orderedList)
            {
                Console.WriteLine($@"Título: {aux}");
            }

        }
    }
}
