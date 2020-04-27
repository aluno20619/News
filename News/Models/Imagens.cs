using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class Imagens
    {
        public Imagens() {
         ListaImagens = new HashSet<Imagens>();
        }
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Legenda { get; set; }


        [ForeignKey(nameof(NoticiaId))]
        public int NoticiasFK { get; set; }
        public Noticias NoticiaId { get; set; }
    }
}
