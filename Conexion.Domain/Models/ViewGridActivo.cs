using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewGridActivo
{
    public int IdActivos { get; set; }

    public string? Usuario { get; set; }

    public string? Departamento { get; set; }

    public string? Plaza { get; set; }

    public string? Negocio { get; set; }

    public string? Folio { get; set; }

    public string? Registro { get; set; }

    public string? NombreActivo { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Proveedor { get; set; }

    public string? Rfc { get; set; }

    public string? Moneda { get; set; }

    public decimal? Monto { get; set; }

    public decimal? Iva { get; set; }

    public DateOnly? Dia { get; set; }

    public DateOnly? Factura { get; set; }

    public DateOnly? Baja { get; set; }

    public string? Status { get; set; }

    public int IdDepartamentos { get; set; }

    public int IdPlaza { get; set; }

    public int IdNegocio { get; set; }

    public int IdStatusAct { get; set; }

    public string? Comentarios { get; set; }

    public int? IdInmovilizado { get; set; }

    public decimal? DblTotal { get; set; }
}
