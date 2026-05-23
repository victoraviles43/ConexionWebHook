using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class CtCuentasEjecutivosNewOld080425
{
    public int Id { get; set; }

    public string? Estatus { get; set; }

    public string? Empresa { get; set; }

    public string? Banco { get; set; }

    public string? Moneda { get; set; }

    public string? Clabe { get; set; }

    public string? FormulaDeIgualacion { get; set; }

    public string? Tipolayout { get; set; }

    public string? Responsable { get; set; }

    public string? Negocio { get; set; }

    public string? Movimientos { get; set; }

    public int? IntIdEstatus { get; set; }

    public int? IntIdEmpresa { get; set; }

    public int? IntIdBanco { get; set; }

    public int? IntIdmoneda { get; set; }

    public int? IntIdNegocio { get; set; }

    public string? Estructura { get; set; }

    public string? Tipo { get; set; }

    public string? Uso { get; set; }

    public string? Etiqueta { get; set; }

    public string? Responsabletoken { get; set; }

    public string? Codigoun { get; set; }

    public DateOnly? Fechadealta { get; set; }

    public string? Observaciones { get; set; }
}
