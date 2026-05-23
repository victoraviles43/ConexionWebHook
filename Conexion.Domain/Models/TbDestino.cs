using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDestino
{
    public int IntIdViatico { get; set; }

    public int? IntIdSolicitdCxp { get; set; }

    public int? IntIdDestino { get; set; }

    public DateTime? FecDeAvion { get; set; }

    public DateTime? FecAlAvion { get; set; }

    public decimal? DblValorticket { get; set; }

    public int? IntIdBancoAvion { get; set; }

    public string? TxtClabeAvion { get; set; }

    public string? TxtCuentaAvion { get; set; }

    public string? TxtHotel { get; set; }

    public DateTime? FecDeHotel { get; set; }

    public DateTime? FecAlHotel { get; set; }

    public int? IntIdBancoHotel { get; set; }

    public DateTime? TxtClabeHotel { get; set; }

    public decimal? DblValorHotel { get; set; }
}
