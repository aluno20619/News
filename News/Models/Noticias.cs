using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class Noticias
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Texto1 { get; set; }
        public string Texto2 { get; set; }
        public string Descricao { get; set; }
        public string Topico { get; set; }
        public bool Visivel { get; set; }
    }
}
