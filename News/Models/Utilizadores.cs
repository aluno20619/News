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

         this.ListaNoticias = new HashSet<Noticias>();
        }


        [Key]
        public int Id { get; set; }
        [RegularExpression("[a-zA-Z]")]
        public string Nome { get; set; }
        public string Email { get; set; }


        public virtual ICollection<Noticias> ListaNoticias {get;set;}

    }
}
