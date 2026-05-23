using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBcColocacion
{
    public string? Cliente { get; set; }

    public string? NombreDelCliente { get; set; }

    public string? Acreditado { get; set; }

    public string? NombreAcreditado { get; set; }

    public string? Teléfono { get; set; }

    public string? ActitividadEconómica { get; set; }

    public string? Ocupación { get; set; }

    public string? VigenciaIne { get; set; }

    public string? CicloAcreditado { get; set; }

    public string? Municipio { get; set; }

    public string? Estado { get; set; }

    public string? Avales { get; set; }

    public double? H { get; set; }

    public double? M { get; set; }

    public string? Oficina { get; set; }

    public string? Zona { get; set; }

    public string? Promotor { get; set; }

    public string? NombrePromotor { get; set; }

    public string? Comisionista { get; set; }

    public string? TipoCliente { get; set; }

    public string? TipoCrédito { get; set; }

    public string? ProductoDeCrédito { get; set; }

    public string? Financiamiento { get; set; }

    public string? LineaDeCrédito { get; set; }

    public string? CódigoEmpleador { get; set; }

    public string? Empleador { get; set; }

    public string? OrigenCrédito { get; set; }

    public string? ConceptoBanco { get; set; }

    public string? CuentaBanco { get; set; }

    public string? Contrato { get; set; }

    public string? Estatus { get; set; }

    public string? Substatus { get; set; }

    public double? Ciclo { get; set; }

    public string? HoraReunión { get; set; }

    public string? DíaReunión { get; set; }

    public double? TasaAnual { get; set; }

    public string? FechaCreación { get; set; }

    public DateTime? FechaDesembolso { get; set; }

    public DateTime? FechaPrimerPago { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public double? NoPagos { get; set; }

    public string? Periodicidad { get; set; }

    public double? Renovados { get; set; }

    public double? Nuevos { get; set; }

    public double? Cuota { get; set; }

    public double? CuotaCargosCalendario { get; set; }

    public double? CuotaTotal { get; set; }

    public double? PagoPorCadaMil { get; set; }

    public double? MontoDesembolsado { get; set; }

    public double? Desembolsado { get; set; }

    public double? Interés { get; set; }

    public double? Impuesto { get; set; }

    public double? AdeudoTotal { get; set; }

    public double? Garantia { get; set; }

    public double? Seguro { get; set; }

    public double? Apertura { get; set; }

    public double? DescuentosPorRefinanciamiento { get; set; }

    public double? DescuentosPorSubproductos { get; set; }

    public double? DescuentosPersonalizados { get; set; }

    public string? AutorizadoPor { get; set; }

    public string? Comentario { get; set; }

    public string? EtiquetasDeContrato { get; set; }

    public string? CódigoMedioDeDivulgación { get; set; }

    public string? MedioDeDivulgación { get; set; }

    public string? AdquisiciónDeBienes { get; set; }

    public string? MétodoDeDesembolso { get; set; }

    public string? Dispersado { get; set; }

    public string? FechaDispersión { get; set; }
}
