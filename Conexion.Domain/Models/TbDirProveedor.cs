using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDirProveedor
{
    public int LngIdDirProveedor { get; set; }

    public int? LngIdProveedor { get; set; }

    public string? TxtDireccion { get; set; }

    public string? TxtCodigoPostal { get; set; }

    public string? TxtPais { get; set; }

    public string? TxtEstado { get; set; }

    public string? TxtCiudad { get; set; }

    public string? TxtMunicipio { get; set; }

    public DateOnly? FecDia { get; set; }

    public bool? BolExtranjero { get; set; }
}
