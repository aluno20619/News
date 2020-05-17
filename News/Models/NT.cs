using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace News.Models
{
	public class NT
	{
		
    [ForeignKey(nameof(Noticiasid))]
    public int NoticiasidFK { get; set; }
    public Noticias Noticiasid { get; set; }

    [ForeignKey(nameof(Topicostopico))]
    public String TopicostopicoFK { get; set; }
    public Topicos Topicotopico { get; set; }
}
}