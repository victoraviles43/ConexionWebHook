using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbPromotoresApp
{
    public int LngIdPromotor { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtApellidoPaterno { get; set; }

    public string? TxtApellidoMaterno { get; set; }

    public string? TxtTelefono { get; set; }

    public string? TxtEmail { get; set; }

    public DateTime? FecAlta { get; set; }

    public DateTime? FecBaja { get; set; }

    public bool? BolActivo { get; set; }
}
