using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBcContrato
{
    public string? IdAcreditado { get; set; }

    public string? IdContrato { get; set; }

    public string? Curp { get; set; }

    public string? Rfc { get; set; }

    public string? Ine { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? Nombre { get; set; }

    public string? FechaNacimiento { get; set; }

    public string? EstadoNacimiento { get; set; }

    public string? Sexo { get; set; }

    public string? Teléfono { get; set; }

    public string? Correo { get; set; }

    public double? ClaveEstadoCivil { get; set; }

    public string? DescripciónEstadoCivil { get; set; }

    public string? EstadoResidencia { get; set; }

    public string? Municipio { get; set; }

    public string? Localidad { get; set; }

    public string? Colonia { get; set; }

    public string? Cp { get; set; }

    public string? Calle { get; set; }

    public string? Manzana { get; set; }

    public string? Lote { get; set; }

    public string? NúmeroExterior { get; set; }

    public string? NúmeroInterior { get; set; }

    public string? NombreGrupo { get; set; }

    public double? IdEstudio { get; set; }

    public string? Estudio { get; set; }

    public string? Actividad { get; set; }

    public string? DescripciónActividad { get; set; }

    public string? FechaInicioActividadProductiva { get; set; }

    public string? UbicaciónNegocio { get; set; }

    public double? PersonasTrabajando { get; set; }

    public double? IngresoSemanal { get; set; }

    public double? RolEnElHogar { get; set; }

    public string? DescripciónRolEnHogar { get; set; }

    public DateTime? FechaDesembolso { get; set; }

    public string? EstatusContrato { get; set; }

    public string? MontoOtorgado { get; set; }

    public string? Fondeador { get; set; }

    public string? NombreProducto { get; set; }

    public string? Plazo { get; set; }

    public string? Periodicidad { get; set; }

    public string? Oficina { get; set; }

    public string? Oficial { get; set; }

    public string? Cargo { get; set; }

    public string? FechaFinContrato { get; set; }

    public string? TipoCliente { get; set; }

    public double? CapitalVigente { get; set; }

    public double? IinterésVigente { get; set; }

    public double? CapitalVencido { get; set; }

    public double? InterésVencido { get; set; }

    public string? AutorizadoPor { get; set; }

    public int? IntIdEmpresa { get; set; }
}
