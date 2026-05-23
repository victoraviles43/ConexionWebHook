using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSucursal
{
    public int LngIdSucursal { get; set; }

    public string? TxtAlias { get; set; }

    public string? TxtDireccion { get; set; }

    public string? TxtReferencia { get; set; }

    public string? TxtLocalidad { get; set; }

    public string? TxtMunicipio { get; set; }

    public int? IntIdEstado { get; set; }

    public int? IntIdPais { get; set; }

    public string? NumCodigoPostal { get; set; }

    public string? NumTel { get; set; }

    public string? NumTel2 { get; set; }

    public string? TxtEmail { get; set; }

    public DateTime? FecInicioOp { get; set; }

    public string? TxtContacto { get; set; }

    public string? NumTelContacto { get; set; }

    public string? TxtFolio { get; set; }

    public string? TxtObservaciones { get; set; }

    public bool? BolActivo { get; set; }
}
