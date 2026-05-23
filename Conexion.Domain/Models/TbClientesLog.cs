using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbClientesLog
{
    public int IntIdClienteLog { get; set; }

    public int IntIdCliente { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime FecMovimiento { get; set; }

    public int IntId { get; set; }

    public string? TxtCliente { get; set; }

    public string? TxtNomCorto { get; set; }

    public string? TxtTelefono { get; set; }

    public string? TxtRfc { get; set; }

    public int? IntIdStatusCli { get; set; }

    public int? IntIdGiro { get; set; }

    public string? TxtDireccion { get; set; }

    public string? TxtComplemento { get; set; }

    public int? IntIdEstado { get; set; }

    public int? IntIdCiudad { get; set; }

    public string? TxtEmail { get; set; }

    public string? NumCodigoPostal { get; set; }

    public DateOnly? FecAlta { get; set; }

    public DateOnly? FecBaja { get; set; }

    public string? TxtServicio { get; set; }

    public string? TxtRegCliente { get; set; }

    public string? TxtCiudad { get; set; }

    public string? TxtContacto { get; set; }

    public string? TxtObservaciones { get; set; }

    public string? TxtUsuario { get; set; }

    public string? TxtTelContacto { get; set; }

    public int? IntIdAreaContacto { get; set; }

    public string? TxtCelular { get; set; }

    public int? IntIdContacto { get; set; }

    public bool? BolHolding { get; set; }

    public int? IntIdHolding { get; set; }

    public int? IntIdTipoCliente { get; set; }

    public int? IntIdEjecutivoOp { get; set; }

    public bool? BolRequiereContrato { get; set; }

    public string? TxtRecibe { get; set; }

    public DateOnly? FecRecibe { get; set; }

    public int? IntIdCobertura { get; set; }

    public string? BolRequiere { get; set; }

    public bool? BolRequiereCap { get; set; }

    public string? TxtIdCrm { get; set; }

    public int? IntIdBrinda { get; set; }

    public int? IntIdEmpresa { get; set; }

    public int? IntIdGrupo { get; set; }

    public DateOnly? FecOperar { get; set; }

    public string? TxtEmailMatriz { get; set; }

    public int? IntIdPlaza { get; set; }
}
