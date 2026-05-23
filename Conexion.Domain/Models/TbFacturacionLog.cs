using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFacturacionLog
{
    public int LngIdFacturasLog { get; set; }

    public int LngIdFacturas { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime FecMovimiento { get; set; }

    public int? LngIdflujo { get; set; }

    public int? LngIdDepositos { get; set; }

    public decimal? DblTotal { get; set; }

    public decimal? DblSubTotal { get; set; }

    public decimal? DblIva { get; set; }

    public decimal? DblPorCliente { get; set; }

    public int? LngIdPorcliente { get; set; }

    public int? IntIdEmpresa { get; set; }
}
