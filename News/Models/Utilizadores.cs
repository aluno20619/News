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
        [Required(ErrorMessage = "O {0} e de preenchimento obrigatorio")]
        [StringLength(40, ErrorMessage = "O {0} nao deve ter mais de {1} caracteres")]
        [RegularExpression("[A-ZÂÓÍÉ][a-záéíúóàèìòùêâîôûãõñäëïöüç]+( | d[oa](s)? | (d)?e |-|'| d')[A-ZÂÓÍÉ][a-záéíúóàèìòùêâîôûãõñäëïöüç]+{2.4}",
            ErrorMessage = "Só são aceites letras.<br />Deve começar com minuscula e de segiuda miniculas.<br />Deve ter 2 a 4 nomes")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O {0} e de preenchimento obrigatorio")]
        [RegularExpression("[A-Za-z@.1234567890]",
            ErrorMessage = "Não deve ter caracteres especiais exceto @ e . (exemplo: +*ºç`^~´... )")]
        [StringLength(64,MinimumLength = 4, ErrorMessage = "O {0} nao deve ter menos de {2}, nem mais de {1} caracteres")]
        public string Email { get; set; }


        public virtual ICollection<Noticias> ListaNoticias {get;set;}

    }
}
