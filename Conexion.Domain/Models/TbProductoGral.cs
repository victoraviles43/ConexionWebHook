using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProductoGral
{
    public int LngIdProductoGral { get; set; }

    public string? TxtFolio { get; set; }

    public string? TxtUsuario { get; set; }

    public DateOnly? FecOperacion { get; set; }

    public int? IntIdSucursal { get; set; }

    public int? IntIdEvento { get; set; }

    public int? IntIdUnidadNegocio { get; set; }

    public int? IntIdProducto { get; set; }

    public int? IntIdEjecutio { get; set; }

    public bool? BolActivo { get; set; }

    public bool? BolContrato { get; set; }
}
