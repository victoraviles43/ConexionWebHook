using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Conexion.Domain.Models
{
    public class ClipApiResponse
    {
       
            public List<ClipApi2> Items { get; set; } = new();

		    [JsonPropertyName("pagination_token")]
		    public string? PaginationToken { get; set; }

		public class ClipApi2
        {
            public string receipt_no { get; set; }

            public DateTime? created_at { get; set; }
            public string user_email { get; set; }

            public string status { get; set; }

            public string payment_method { get; set; }

            public string sub_type { get; set; }

            public string currency { get; set; }

            public string terms { get; set; }
            public decimal? amount { get; set; }

            public decimal? tip { get; set; }

            public decimal? total { get; set; }

            public string merchant_invoice { get; set; }

            public Location location { get; set; }

            public CardInfo card { get; set; }
        }

        public class Location
        {
            public string longitude { get; set; }

            public string latitude { get; set; }
        }

        public class CardInfo
        {
            public string Brand { get; set; }
            public string Issuer { get; set; }
            public string Last4 { get; set; }
        }
    }
}
