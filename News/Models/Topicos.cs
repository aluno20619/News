using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace News.Models
{
	public class Topicos
	{
		public Topicos()
		{
			//ListaNT = new HashSet<NT>();
		}

		[Key]
		public String Id { get; set; }


		//public ICollection<NT> ListaNT { get; set; }
	}
}