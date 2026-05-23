using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFullpassPalco4
{
    public int LngIdFullpass { get; set; }

    public string NoOrden { get; set; } = null!;

    public DateOnly FechaOperacion { get; set; }

    public string Producto { get; set; } = null!;

    public int? NoDeBoletos { get; set; }

    public string? Evento { get; set; }

    public string? Zona { get; set; }

    public string? PasarelaDePago { get; set; }

    public decimal? PrecioDelBoleto { get; set; }

    public decimal? CargoPorServicioAntesDeIva { get; set; }

    public decimal? IvaCargosPorServicio { get; set; }

    public decimal? Validacion { get; set; }

    public decimal? FeeDeLaPasarela { get; set; }

    public decimal? CargoPorServicioTotal { get; set; }

    public decimal? TotalCompra { get; set; }

    public decimal? FondoDeGarantia { get; set; }

    public string? OrderStatusName { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public string? IpAddress { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? CanalImpresion { get; set; }

    public string? Provedor { get; set; }
}
