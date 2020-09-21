﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiniWebCrawler.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            String dados = $"Nome: {Nome}\nID: {Id}";
            return dados;
        }
    }
}
