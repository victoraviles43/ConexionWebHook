using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBcIngreso
{
    public string? Cliente { get; set; }

    public string? NombreDelCliente { get; set; }

    public string? Acreditado { get; set; }

    public string? NombreAcreditado { get; set; }

    public string? Municipio { get; set; }

    public string? Estado { get; set; }

    public string? Oficina { get; set; }

    public string? Promotor { get; set; }

    public string? NombrePromotor { get; set; }

    public string? TipoCliente { get; set; }

    public string? TipoCrédito { get; set; }

    public string? Producto { get; set; }

    public string? Financiamiento { get; set; }

    public string? CódigoEmpleador { get; set; }

    public string? Empleador { get; set; }

    public string? NombreBancoBóveda { get; set; }

    public string? CuentaCaja { get; set; }

    public string? Contrato { get; set; }

    public string? Estatus { get; set; }

    public DateTime? FechaDesembolso { get; set; }

    public string? FechaPrimerPago { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public double? NoPagos { get; set; }

    public string? Periodicidad { get; set; }

    public double? Cuota { get; set; }

    public double? CuotaCargosCalendario { get; set; }

    public string? TipoDeCobro { get; set; }

    public DateTime? FechaAplicación { get; set; }

    public DateTime? FechaTransacción { get; set; }

    public string? Folio { get; set; }

    public double? Depósito { get; set; }

    public double? Garantia { get; set; }

    public double? Seguros { get; set; }

    public double? ComisiónApertura { get; set; }

    public double? PagoAContrato { get; set; }

    public double? Capital { get; set; }

    public double? Interés { get; set; }

    public double? Iva { get; set; }

    public double? CargosCalendario { get; set; }

    public double? IvaCargosCalendario { get; set; }

    public double? Moratorio { get; set; }

    public double? IvaMoratorio { get; set; }

    public double? PagoAnticipado { get; set; }

    public double? Excedente { get; set; }

    public double? OtrosIngresos { get; set; }

    public string? Origen { get; set; }

    public string? Referencia { get; set; }

    public DateOnly? FImportacion { get; set; }

    public int IdRegistro { get; set; }

    public int? IntIdEmpresa { get; set; }
}
