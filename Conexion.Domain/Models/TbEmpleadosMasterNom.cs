using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEmpleadosMasterNom
{
    public int IntIdRegistro { get; set; }

    public int? IntIdempleado { get; set; }

    public string? TxtNombreCompleto { get; set; }

    public string? TxtApellidoP { get; set; }

    public string? TxtApellidoM { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtUdn { get; set; }

    public string? TxtArea { get; set; }

    public string? TxtDpto { get; set; }

    public string? TxtPuesto { get; set; }

    public string? TxtUbicacion { get; set; }

    public bool? BolActivo { get; set; }
}
