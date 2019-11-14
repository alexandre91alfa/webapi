using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class Event
    {
        [Key]
        public int EventoId { get; set; }
        public string Tema { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public int QtPessoas { get; set; }
        public string Lote { get; set; }
    }
}
