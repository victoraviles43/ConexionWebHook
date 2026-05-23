using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFinanciamiento
{
    public int LngIdFinanciamiento { get; set; }

    public int? IntIdCliente { get; set; }

    public int? LngIdEmpresa { get; set; }

    public int? IntIdCuentasPg { get; set; }

    public decimal? DblValor { get; set; }

    public int? IntIdMoneda { get; set; }

    public int? IntIdTipoDeposito { get; set; }

    public DateTime? FecDia { get; set; }

    public DateOnly? FecDeposito { get; set; }

    public DateOnly? FecVencimiento { get; set; }

    public decimal? DblTipoCambio { get; set; }

    public decimal? DblComisionBancaria { get; set; }

    public decimal? DblIvaBancario { get; set; }

    public int? IntIdstatusFin { get; set; }

    public int? IntIdEmpresa { get; set; }
}
