using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace News.Models
{
	public class NT
	{

        [Key, Column(Order = 1)]
        public Noticias Noticiasid { get; set; }
        [Key, Column(Order = 2)]
        public Topicos Topico { get; set; }


        [ForeignKey(nameof(Noticiasid))]
        public int NoticiasidFK { get; set; }
        [ForeignKey(nameof(Topico))]
        public String TopicostopicoFK { get; set; }
        
}
}