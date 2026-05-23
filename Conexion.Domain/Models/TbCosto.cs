using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCosto
{
    public int LngIdIngresos { get; set; }

    public DateOnly? FecFecha { get; set; }

    public string? TxtUnidadNegocio { get; set; }

    public double? IntIdUnidadNegocio { get; set; }

    public string? TxtConcepto { get; set; }

    public string? TxtMoneda { get; set; }

    public double? DblImporte { get; set; }

    public string? TxtTipoIngreso { get; set; }

    public string? TxtCliente { get; set; }

    public string? TxtSucursal { get; set; }

    public string? TxtEvento { get; set; }

    public string? TxtFiesta { get; set; }

    public string? TxtComentario { get; set; }
}
