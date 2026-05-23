using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbComFlu
{
    public int LngIdComFlu { get; set; }

    public int? LngIdComisionesPro { get; set; }

    public int? LngIdflujo { get; set; }
}
