using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailabilityNotify.Models
{
    public class ProcessingResultSheet
    {
        public int Id { get; set; }

        public string Fornecedor { get; set; }

        public DateTime Vencimento { get; set; }

        public decimal ValorDevido { get; set; }

        public DateTime Pagamento { get; set; }

        public decimal ValorPago { get; set; }

        public string Descricao { get; set; }
    }
}
