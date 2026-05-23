using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewGridCxr
{
    public int IdSolicitdCxR { get; set; }

    public string? Solicitante { get; set; }

    public string? Departamento { get; set; }

    public string? Plaza { get; set; }

    public string? Negocio { get; set; }

    public string? Folio { get; set; }

    public string? Beneficiario { get; set; }

    public string? TipoPago { get; set; }

    public string? Registro { get; set; }

    public string? Moneda { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Iva { get; set; }

    public DateTime? Dia { get; set; }

    public DateTime? ProxVencimiento { get; set; }

    public DateTime? Pago { get; set; }

    public string? Status { get; set; }

    public int IntIdPlaza { get; set; }

    public int IntIdNegocio { get; set; }

    public int IntIdDepartamentos { get; set; }

    public int IntIdStatus { get; set; }

    public string? Concepto { get; set; }

    public int? IntTipoPago { get; set; }

    public bool? Congelado { get; set; }
}
