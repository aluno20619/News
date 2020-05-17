using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class Utilizadores
    {
        public Utilizadores() {
         ListaNoticias = new HashSet<Noticias>();
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public ICollection<Noticias> ListaNoticias {get;set;}
    }
}
