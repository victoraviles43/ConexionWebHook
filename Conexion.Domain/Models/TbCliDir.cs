using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCliDir
{
    public Guid LngIdCliDir { get; set; }

    public Guid? LngIdCliente { get; set; }

    public Guid? LngIdDireccion { get; set; }

    public bool? BolCongelar { get; set; }
}
