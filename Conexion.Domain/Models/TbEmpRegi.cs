using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEmpRegi
{
    public int LngIdEmpRegi { get; set; }

    public int? LngIdEmpresa { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdRegion { get; set; }

    public DateOnly? FecDia { get; set; }

    public bool? BolActivo { get; set; }
}
