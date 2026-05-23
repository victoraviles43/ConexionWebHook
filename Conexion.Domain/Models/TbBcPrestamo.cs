using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBcPrestamo
{
    public int LngIdRegistro { get; set; }

    public string? TxtOficina { get; set; }

    public string? TxtZona { get; set; }

    public int? NumPromotor { get; set; }

    public string? TxtNombrePromotor { get; set; }

    public string? TxtComisionista { get; set; }

    public int? NumContrato { get; set; }

    public int? NumCliente { get; set; }

    public string? TxtNombreCliente { get; set; }

    public DateOnly? FecDesembolso { get; set; }

    public DateOnly? FecVencimiento { get; set; }

    public int? NumPagos { get; set; }

    public decimal? DblCapital { get; set; }

    public int? NumDiasMora { get; set; }

    public decimal? DblTotalVigente { get; set; }

    public decimal? DblTotalVencido { get; set; }

    public decimal? DblSaldoActual { get; set; }

    public DateOnly? FecCierre { get; set; }
}
