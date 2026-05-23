using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSaldo
{
    public int LngIdSaldos { get; set; }

    public int? IntIdPortafolio { get; set; }

    public decimal? DblAbonos { get; set; }

    public decimal? DblRetiros { get; set; }

    public decimal? DblTraspaso1 { get; set; }

    public decimal? DblTraspaso2 { get; set; }

    public decimal? DblOtro { get; set; }

    public decimal? DblSaldoInicial { get; set; }

    public decimal? DblCorteCupon { get; set; }

    public decimal? DblAmortizacion { get; set; }

    public decimal? DblCobroDividendo { get; set; }

    public decimal? DblPrimaOpciones { get; set; }

    public decimal? DblIsr { get; set; }

    public decimal? DblIsrotro { get; set; }

    public decimal? DblVencimiento { get; set; }

    public decimal? DblCompras { get; set; }

    public decimal? DblVentas { get; set; }

    public decimal? DblTotal { get; set; }

    public int? IntIdMoneda { get; set; }

    public decimal? DblTc { get; set; }

    public DateTime? FecInicio { get; set; }

    public DateTime? FecFin { get; set; }

    public int? IntIdStatus { get; set; }
}
