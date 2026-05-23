using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDireccionProveedore
{
    public int LngIdDireccionProveedor { get; set; }

    public string? TxtDireccion { get; set; }

    public int? LngIdProveedor { get; set; }

    public int? IntIdEstados { get; set; }

    public string? TxtCiudad { get; set; }

    public string? TxtCodigoPostal { get; set; }

    public int? LngIdTipoDirecciones { get; set; }
}
