using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEvento
{
    public int LngIdEvento { get; set; }

    public string? TxtAlias { get; set; }

    public bool? BolFinan { get; set; }

    public string? TxtVenue { get; set; }

    public string? TxtDireccion { get; set; }

    public string? TxtLocalidad { get; set; }

    public string? TxtMunicipio { get; set; }

    public int? IntIdEstado { get; set; }

    public int? IntIdPais { get; set; }

    public string? NumCodigoPostal { get; set; }

    public string? DblAforo { get; set; }

    public int? IntIdGiro { get; set; }

    public DateTime? FecIniServ { get; set; }

    public DateTime? FecIniEve { get; set; }

    public DateTime? FecFinEve { get; set; }

    public string? TxtContacto { get; set; }

    public string? TxtTelefono { get; set; }

    public string? TxtEmail { get; set; }

    public string? TxtFolio { get; set; }
}
