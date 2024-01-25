using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcorrenciaTrigger.Models
{
    public class Ocorrencia
    {
        public int Id { get; set; }
        public string EnderecoCompleto { get; set; }
        public int QuantidadeVolumes { get; set; }
        public DateTime? DtCriacao { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
    }
}
