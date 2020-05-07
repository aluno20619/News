﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class Utilizadores
    {
        [Key]
        public int Id { get; set; }
        [RegularExpression("[a-zA-A]+")]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //sugestão:Envez de bin -> booleano
        public bool Premium { get; set; }


    }
}