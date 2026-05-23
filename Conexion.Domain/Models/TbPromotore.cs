using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbPromotore
{
    public Guid IntIdPromotor { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtSnombre { get; set; }

    public string? TxtApaterno { get; set; }

    public string? TxtAmaterno { get; set; }

    public string? TxtPromotor { get; set; }

    public string? TxtTelefono { get; set; }

    public string? TxtEmail { get; set; }

    public Guid? IntIdSucursal { get; set; }

    public Guid? IntIdOficina { get; set; }
}
