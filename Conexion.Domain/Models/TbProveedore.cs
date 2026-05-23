using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProveedore
{
    public int LngIdProveedor { get; set; }

    public string? TxtRazonSocial { get; set; }

    public string? TxtNombreComercial { get; set; }

    public string? TxtRfc { get; set; }

    public decimal? DblAcumulado { get; set; }

    public bool? BolActivo { get; set; }

    public string? TxtComentarios { get; set; }

    public DateOnly? FecAlta { get; set; }

    public DateOnly? FecBaja { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtTelefono { get; set; }

    public string? TxtEmail { get; set; }
}
