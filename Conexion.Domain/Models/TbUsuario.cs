using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbUsuario
{
    public Guid IntIdUsuario { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtSnombre { get; set; }

    public string? TxtApaterno { get; set; }

    public string? TxtAmaterno { get; set; }

    public string? TxtCorreo { get; set; }

    public string? TxtTelefono { get; set; }

    public string? TxtContrasena { get; set; }

    public DateOnly? FecCreo { get; set; }

    public DateOnly? FecEdito { get; set; }

    public int? IntIdRolUsuario { get; set; }

    public bool? BolActivo { get; set; }
}
