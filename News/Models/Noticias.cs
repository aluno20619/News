using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class Noticias
    {
        public Noticias() {
         ListaNoticias = new HashSet<Noticias>();
        }
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto1 { get; set; }
        public string Texto2 { get; set; }
        public ICollection<Imagens> ListaImagens { get; set; }
        public ICollection<Partilha> ListaPartilha { get; set; }
    }
}
