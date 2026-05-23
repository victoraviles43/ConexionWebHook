using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbClientesOper
{
    public int IntIdCliente { get; set; }

    public string? TxtCliente { get; set; }

    public string? TxtRfc { get; set; }

    public int? IntIdStatusCli { get; set; }

    public string? TxtDireccion { get; set; }

    public int? IntIdEstado { get; set; }

    public string? TxtEmail { get; set; }

    public decimal? NumCodigoPostal { get; set; }

    public DateOnly? FecAlta { get; set; }

    public DateOnly? FecBaja { get; set; }

    public string? TxtCiudad { get; set; }

    public string? TxtContacto { get; set; }

    public string? TxtUsuario { get; set; }

    public string? TxtTelContacto { get; set; }

    public bool? BolMigrado { get; set; }

    public int? IntIdEmpresa { get; set; }
}
