using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeRegSer
{
    public int LngIdRegSer { get; set; }

    public int? LngIdRegGen { get; set; }

    public int? IntIdServicio { get; set; }
}
