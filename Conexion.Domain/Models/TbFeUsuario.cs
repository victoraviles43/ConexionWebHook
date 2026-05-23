using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeUsuario
{
    public int LngIdUsuario { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtApellido { get; set; }

    public string? TxtNomCorto { get; set; }

    public string? TxtContrasena { get; set; }

    public string? TxtEmail { get; set; }

    public string? TxtTelefono { get; set; }

    public int? IntIdPlaza { get; set; }

    public DateOnly? FecAlta { get; set; }

    public DateOnly? FecBaja { get; set; }

    public bool? BolActivo { get; set; }

    public int? IntIdRol { get; set; }
}
