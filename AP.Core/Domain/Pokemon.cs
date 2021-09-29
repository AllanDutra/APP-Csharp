using System;

namespace AP.Core.Domain
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public double Poder { get; set; }

        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        
    }
}