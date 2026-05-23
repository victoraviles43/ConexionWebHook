using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class VwSolicitudesPagosResuman
{
    public int IdSolicitudrecurso { get; set; }

    public string? RegistroDsol { get; set; }

    public string? ValorSol { get; set; }

    public string? MonedaSol { get; set; }

    public string? StatusSol { get; set; }

    public DateOnly? FecInicioSol { get; set; }

    public DateOnly? FecVencimientoSol { get; set; }

    public string? EmpresaSolicita { get; set; }

    public string? UsuarioSolicita { get; set; }

    public int IdPagorecurso { get; set; }

    public string? RegistroPag { get; set; }

    public string? ValorPag { get; set; }

    public string? TotalAbonado { get; set; }

    public string? TotalDeuda { get; set; }

    public DateOnly? FecUltimoAbono { get; set; }

    public string? MonedaPag { get; set; }

    public string? StatusPag { get; set; }

    public DateOnly? FecInicioPag { get; set; }

    public DateOnly FecVenPag { get; set; }

    public string? EmpresaPaga { get; set; }

    public string? UsuarioPagador { get; set; }
}
