using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace News.Models
{
	public class NI
	{
        [ForeignKey(nameof(Noticiasid))]
        public int NoticiasidFK { get; set; }
        public Noticias Noticiasid { get; set; }

        [ForeignKey(nameof(Imagensid))]
        public String ImagensidFK { get; set; }
        public Imagens Imagensid { get; set; }
    }
}