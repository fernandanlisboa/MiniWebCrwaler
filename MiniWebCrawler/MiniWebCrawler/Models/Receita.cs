﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiniWebCrawler.Models
{
    public class Receita
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // public int Likes { get; set; }
     //   public TimeSpan Tempo { get; set; }
   //     public int Porcao { get; set; }
        public virtual Autor Autor { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
