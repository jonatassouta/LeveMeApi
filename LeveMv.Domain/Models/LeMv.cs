﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeveMv.Domain.Models
{
    public class LeMv
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public Cliente Clientes { get; set; }

        public LeMv()
        { 
        
        }
        public LeMv(Guid id, string nome)
        {
            ID = id;
            Nome = nome;
        }
    }
}