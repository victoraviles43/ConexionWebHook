using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Domain.Util
{
    public class ResponseObject
    {
        public string Mensaje { get; set; }
        public bool Success { get; set; }
        public Object Data { get; set; }
    }
}
