using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbContactoInt
{
    public int LngIdContacto { get; set; }

    public string? TxtNombre { get; set; }

    public int? IntIdArea { get; set; }

    public string? TxtTelefono { get; set; }

    public string? TxtEmail { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdEmpresa { get; set; }

    public bool? BolActivo { get; set; }

    public string? TxtRegistro { get; set; }

    public string? TxtApellido { get; set; }
}
