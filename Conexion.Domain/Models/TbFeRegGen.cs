using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFeRegGen
{
    public int LngIdRegGen { get; set; }

    public DateTime? FecDia { get; set; }

    public string? TxtRegGen { get; set; }

    public string? TxtNombreCom { get; set; }

    public string? TxtContacto { get; set; }

    public string? TxtTelefono { get; set; }

    public int? IntIdEstados { get; set; }

    public int? IntIdActividadEco { get; set; }

    public string? TxtEmail { get; set; }

    public int? IntIdServicio { get; set; }

    public string? TxtOtraActividadEco { get; set; }

    public int? LngIdUsuario { get; set; }
}
