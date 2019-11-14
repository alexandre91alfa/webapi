using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class Event
    {
        public string Tema { get; set; }
        public int EventoId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public int QtPessoas { get; set; }
        public string Lote { get; set; }
    }
}
