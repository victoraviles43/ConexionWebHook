using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbComisionesProLog
{
    public int LngIdComisionesProLog { get; set; }

    public int LngIdComisionesPro { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime FecMovimiento { get; set; }

    public int? LngIdflujo { get; set; }

    public int? LngIdContacto { get; set; }

    public int? IntIdFormaPago { get; set; }

    public decimal? DblComisionBase { get; set; }

    public decimal? DblMonto { get; set; }

    public int? IntIdMoneda { get; set; }

    public DateOnly? FecDia { get; set; }

    public decimal? DblTipoCambio { get; set; }

    public int? IntIdCliente { get; set; }

    public int? IntIdTipoImp { get; set; }

    public bool? BolCostoOper { get; set; }

    public decimal? DblPorPiso { get; set; }

    public int? IntIdEmpresa { get; set; }

    public bool? BolTradicional { get; set; }
}
