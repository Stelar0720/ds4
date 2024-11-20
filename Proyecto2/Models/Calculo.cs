using System.ComponentModel.DataAnnotations;
using System;

namespace Proyecto2.Models
{
    public class Calculo
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public double Resultado { get; set; }
        public DateTime Fecha { get; set; }
    }
}

