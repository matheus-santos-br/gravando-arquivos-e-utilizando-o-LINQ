using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Arquivos_e_LINQ.Models
{
    public class Livros
    {
        [JsonPropertyName("titulo")]
        public string titulo { get; set; }

        [JsonPropertyName("autor")]
        public string autor { get; set; }

        [JsonPropertyName("ano_publicacao")]
        public int ano_publicacao { get; set; }

        [JsonPropertyName("genero")]
        public string genero { get; set; }

        [JsonPropertyName("paginas")]
        public int paginas { get; set; }

        [JsonPropertyName("editora")]
        public string editora { get; set; }
    }
}
