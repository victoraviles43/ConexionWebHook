using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBcCobranzaCredito
{
    public string? Cliente { get; set; }

    public string? NombreDelCliente { get; set; }

    public string? Oficina { get; set; }

    public string? Promotor { get; set; }

    public string? NombrePromotor { get; set; }

    public string? Asentamiento { get; set; }

    public string? Contrato { get; set; }

    public string? Estatus { get; set; }

    public string? DíaReunión { get; set; }

    public string? HoraReunión { get; set; }

    public double? TasaAnual { get; set; }

    public DateTime? FechaDesembolso { get; set; }

    public DateTime? FechaPrimerPago { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? Producto { get; set; }

    public double? NoPagos { get; set; }

    public string? Periodicidad { get; set; }

    public double? Cuota { get; set; }

    public double? CuotaCalendario { get; set; }

    public double? CuotaTotal { get; set; }

    public double? PagoPorMil { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? NoPago { get; set; }

    public double? TotalAPagar { get; set; }

    public double? Saldo { get; set; }

    public double? Pago { get; set; }

    public double? PagoCalendario { get; set; }

    public double? PagoTotal { get; set; }

    public double? SaldoNuevo { get; set; }

    public double? SaldoAtrasado { get; set; }

    public double? SaldoCalendarioAtrasado { get; set; }

    public double? InterésMoratorio { get; set; }

    public double? OtrosCargosDeVencimiento { get; set; }

    public double? TotalAtrasado { get; set; }

    public double? DíasMora { get; set; }

    public DateOnly? FImportacion { get; set; }

    public int IdRegistro { get; set; }
}
