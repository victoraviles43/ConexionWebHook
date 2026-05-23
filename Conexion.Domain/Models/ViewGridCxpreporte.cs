using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewGridCxpreporte
{
    public string? Beneficiario { get; set; }

    public string? Comprovante { get; set; }

    public string? Concepto { get; set; }

    public bool? Congelado { get; set; }

    public string? Cuenta { get; set; }

    public string? Departamento { get; set; }

    public DateTime? Dia { get; set; }

    public string? EmpresaPg { get; set; }

    public string? Folio { get; set; }

    public bool? Gastofijo { get; set; }

    public int IdSolicitdCxp { get; set; }

    public string? Moneda { get; set; }

    public string? Negocio { get; set; }

    public DateTime? Pago { get; set; }

    public string? Plaza { get; set; }

    public DateTime? ProxVencimiento { get; set; }

    public string? Registro { get; set; }

    public string? Rfc { get; set; }

    public string? Solicitante { get; set; }

    public string? Status { get; set; }

    public string? TipoPago { get; set; }

    public string? TipoServicio { get; set; }

    public string? TxtBanco { get; set; }

    public string? TxtClabe { get; set; }

    public string? TxtComentarios { get; set; }

    public string? TxtCuenta { get; set; }

    public string? TxtIban { get; set; }

    public string? TxtMotivo { get; set; }

    public string? TxtNombreComercial { get; set; }

    public string? TxtTarjeta { get; set; }

    public string? TxtTipoGasto { get; set; }

    public decimal? DblTipoCambio { get; set; }

    public decimal? Importe { get; set; }

    public int? IntIdDepartamentos { get; set; }

    public int? IntIdNegocio { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdStatus { get; set; }

    public int? IntTipoPago { get; set; }

    public decimal? Iva { get; set; }

    public int? Clabe { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? Cuentas { get; set; }

    public int? Motivo { get; set; }

    public string TableNames { get; set; } = null!;
}
