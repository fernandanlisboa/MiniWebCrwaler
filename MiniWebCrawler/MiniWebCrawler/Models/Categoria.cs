﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiniWebCrawler.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Receita> Receitas { get; set; }
    }
}