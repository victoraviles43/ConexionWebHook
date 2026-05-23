using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbAlertum
{
    public Guid LngIdAlerta { get; set; }

    public Guid? LngIdCliente { get; set; }

    public Guid? LngIdLog { get; set; }

    public DateOnly? FecCreo { get; set; }

    public Guid? LngIdAltaPrevencion { get; set; }

    public bool? BolCongelar { get; set; }
}
