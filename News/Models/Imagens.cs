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
        public Imagens(){
            ListaNI = new HashSet<NI>();
        }

        [Key]
        public int Id { get; set; }
        public string Legenda { get; set; }


        public ICollection<NI> ListaNI {get;set;}
    }
}
