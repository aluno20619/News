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
        

       
       [Key, Column(Order = 0)]
        public int Noticiasid { get; set; }
       [Key, Column(Order = 1)]
        public int Imagensid { get ; set; }


        public Noticias Noticiaid { get; set; }
        public Imagens Imagemid { get; set; }


        [ForeignKey(nameof(Noticiaid))]
        public int NoticiasFK { get; set; }

        [ForeignKey(nameof(Imagemid))]
        public int ImagensFK { get; set; }

    }
}