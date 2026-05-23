using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEmpresasPg
{
    public int IntIdEmpresaPg { get; set; }

    public int? IntId { get; set; }

    public string? TxtEmpresaPg { get; set; }

    public string? TxtRfc { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdPais { get; set; }

    public bool? BolBaja { get; set; }

    public int? IntIdnegocio { get; set; }
}
