using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewGridCxprep
{
    public int IdSolicitdCxp { get; set; }

    public string? Solicitante { get; set; }

    public string? Departamento { get; set; }

    public string? Plaza { get; set; }

    public string? Negocio { get; set; }

    public string? TipoServicio { get; set; }

    public string? Cuenta { get; set; }

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

    public string? Concepto { get; set; }

    public string? Comprovante { get; set; }

    public string? Referencia { get; set; }

    public string Congelado { get; set; } = null!;

    public string? TxtEmpresaPg { get; set; }

    public int? IdDepartamentos { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public string? CuentaBk { get; set; }
}
