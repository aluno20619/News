﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class Partilha
    {
        //Não se é assim que se junta as duas numa chave primária
        [Key]
        public Utilizadores UtilizadorId { get; set; }
        [Key]
        public Noticias NoticiaId { get; set; }

        [ForeignKey(nameof(NoticiaId))]
        public int NoticiasFK { get; set; }

        [ForeignKey(nameof(UtilizadorId))]
        public int UtilizadoresFK { get; set; }
        

    }
}
