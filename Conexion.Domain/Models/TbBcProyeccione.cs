using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBcProyeccione
{
    public string? Cliente { get; set; }

    public string? NombreCliente { get; set; }

    public string? Acreditado { get; set; }

    public string? NombreAcreditado { get; set; }

    public string? Teléfono { get; set; }

    public string? Municipio { get; set; }

    public string? Estado { get; set; }

    public string? Dirección { get; set; }

    public string? Oficina { get; set; }

    public string? Zona { get; set; }

    public string? Promotor { get; set; }

    public string? NombrePromotor { get; set; }

    public string? Comisionista { get; set; }

    public string? TipoCliente { get; set; }

    public string? TipoDeCredito { get; set; }

    public string? Financiamiento { get; set; }

    public string? ConceptoFinanciamiento { get; set; }

    public string? CódigoEmpleador { get; set; }

    public string? Empleador { get; set; }

    public string? Contrato { get; set; }

    public string? Estatus { get; set; }

    public string? SubEstatus { get; set; }

    public string? Periodicidad { get; set; }

    public DateTime? FechaDesembolso { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public DateTime? FechaÚltimoPago { get; set; }

    public string? Etiquetas { get; set; }

    public string? FechaPago { get; set; }

    public double? Capital { get; set; }

    public double? Interés { get; set; }

    public double? Impuesto { get; set; }

    public double? AdeudoTotal { get; set; }

    public double? CapitalProyectado { get; set; }

    public double? InterésProyectado { get; set; }

    public double? ImpuestoProyectado { get; set; }

    public double? CargosCalendarioProyectado { get; set; }

    public double? ImpuestoCargosCalendarioProyectado { get; set; }

    public double? TotalProyectado { get; set; }

    public double? CapitalPagado { get; set; }

    public double? InterésPagado { get; set; }

    public double? ImpuestoPagado { get; set; }

    public double? CargosCalendarioPagado { get; set; }

    public double? ImpuestoCargosCalendarioPagado { get; set; }

    public double? TotalPagado { get; set; }

    public double? CapitalPorPagar { get; set; }

    public double? InterésPorPagar { get; set; }

    public double? ImpuestoPorPagar { get; set; }

    public double? CargosCalendarioPorPagar { get; set; }

    public double? ImpuestoCargosCalendarioPorPagar { get; set; }

    public double? TotalPorPagar { get; set; }
}
