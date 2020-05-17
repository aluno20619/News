using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace News.Models
{
	public class Topico
	{
		public Topico()
		{
			ListaNT = new HashSet<NT>();
		}

		[Key]
		public String Id { get; set; }

		public ICollection<NT> ListaNT { get; set; }
	}
}