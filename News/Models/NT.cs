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
        public int Noticiasid { get; set; }
        [Key, Column(Order = 0)]
        public string Topicosid { get; set; }


        public virtual Noticias Noticiaid { get; set; }
        
        public virtual Topicos Topicoid { get; set; }

        [ForeignKey(nameof(Noticiaid))]
        public int NoticiasFK { get; set; }

        [ForeignKey(nameof(Topicoid))]
        public string TopicosFK { get; set; }

    }
}