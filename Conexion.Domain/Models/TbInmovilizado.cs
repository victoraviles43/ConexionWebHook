using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbInmovilizado
{
    public int IntIdInmovilizado { get; set; }

    public int? IntIdActivos { get; set; }

    public string? TxtActivoDep { get; set; }

    public int? IntCantidad { get; set; }

    public DateOnly? FecActivoDep { get; set; }

    public decimal? DblValor { get; set; }

    public int? IntMeses { get; set; }

    public decimal? DblDepreciacion { get; set; }

    public decimal? DblMontoInv { get; set; }

    public decimal? DblIva { get; set; }

    public decimal? DblTotal { get; set; }

    public decimal? DblMargen { get; set; }

    public string? TxtMarca { get; set; }

    public string? TxtModelo { get; set; }

    public string? TxtRegistro { get; set; }

    public decimal? DblInversion { get; set; }

    public decimal? DblTotalDep { get; set; }

    public string? TxtUbicacion { get; set; }

    public byte[]? ArQrImagen { get; set; }

    public byte[]? ArImagen { get; set; }

    public string? TxtNumSerie { get; set; }

    public string? TxtComentarios { get; set; }
}
