using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEmpresa
{
    public int LngIdEmpresa { get; set; }

    public string? TxtEmpresa { get; set; }

    public int? IntIdGiro { get; set; }

    public int? IntIdNivel { get; set; }

    public int? IntIdTipo { get; set; }

    public string? TxtEstructura { get; set; }

    public bool? BolActiva { get; set; }

    public DateOnly? FecInicio { get; set; }

    public DateOnly? FecFin { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdNegocio { get; set; }
}
