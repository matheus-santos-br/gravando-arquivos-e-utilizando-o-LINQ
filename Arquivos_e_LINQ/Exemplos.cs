using Arquivos_e_LINQ.Filters;
using Arquivos_e_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_e_LINQ
{
    public class Exemplos
    {
        public void UsandoLinq(List<Livros> Livros)
        {
            LinqFilter.Filter(Livros);

            Console.WriteLine("Lista Ordenada: ");
            LinqOrder.Order(Livros);

            LinqFilter.FilterByGenre(Livros, "Ficção Científica");
            LinqFilter.FilterByGenre(Livros, "Fantasia");

            LinqFilter.FilterByAuthor(Livros, "J.R.R. Tolkien");
            LinqFilter.FilterByAuthor(Livros, "George Orwell");
        }
        public void ExtrairLivrosFavoritos(List<Livros> Livros)
        {
            LivrosFavoritos favoritos = new LivrosFavoritos();
            favoritos.Add(Livros[0]);
            favoritos.Add(Livros[2]);
            favoritos.Add(Livros[4]);

            //favoritos.Show();

            favoritos.Extrair();
        }
    }
}
