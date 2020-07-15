using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace News.Models
{
	public class NI
	{
        

       
       [Key, Column(Order = 1)]
        public Noticias Noticiasid { get; set; }
       [Key, Column(Order = 0)]
        public Imagens Imagensid { get; set; }


        [ForeignKey(nameof(Noticiasid))]
        public int NoticiasidFK { get; set; }

        [ForeignKey(nameof(Imagensid))]
        public String ImagensidFK { get; set; }

    }
}