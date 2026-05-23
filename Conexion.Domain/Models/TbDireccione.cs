using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDireccione
{
    public Guid LngIdDireccion { get; set; }

    public string? TxtDireccion { get; set; }

    public string? TxtComplemento { get; set; }

    public Guid? IntIdEstado { get; set; }

    public Guid? IntIdCiudad { get; set; }

    public int? IntIdPais { get; set; }

    public int? IntIdTipoDir { get; set; }
}
