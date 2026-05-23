using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDocEntregaSe
{
    public int LngIdDocEntrega { get; set; }

    public int? IntIdEntregaFlujo { get; set; }

    public string? TxtRutaEntrega { get; set; }

    public bool? BolActivo { get; set; }

    public string? TxtNombre { get; set; }
}
