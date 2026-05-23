using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Domain.Models
{
    public class BillpocketApiResponse
    {

        public List<BillpocketTransaction> Data { get; set; }
        public int CurrentPage { get; set; }
        public int PerPage { get; set; }
        public int Total { get; set; }

        public class BillpocketTransaction
        {
            public int transaction_id { get; set; }
            public string transaction_type { get; set; }
            public decimal? total_amount { get; set; }
            public decimal? tip { get; set; }
            public decimal? surcharge { get; set; }
            public decimal? subtotal { get; set; }
            public string rejection_code { get; set; }
            public decimal? retention { get; set; }
            public string msi { get; set; }
            public string masked_card { get; set; }
            public string error_detail { get; set; }
            public string transaction_status { get; set; }
            public string device { get; set; }
            public DateTime? date { get; set; }
            public bool? countercharged { get; set; }
            public decimal? commission { get; set; }
            public string capture_method { get; set; }
            public string card_type { get; set; }
            public string card_brand { get; set; }
            public string bank { get; set; }
            public string authorization_number { get; set; }
            public string details { get; set; }
            public decimal? vat { get; set; }
        }
    }
}
