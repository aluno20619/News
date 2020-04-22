using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class Imagens
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Legenda { get; set; }
        public int NoticiasId { get; set; }
    }
}
