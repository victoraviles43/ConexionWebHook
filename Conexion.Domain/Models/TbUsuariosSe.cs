using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbUsuariosSe
{
    public int IntIdusuario { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtApellido { get; set; }

    public string? TxtNomCorto { get; set; }

    public string? TxtPassword { get; set; }

    public int BolActivo { get; set; }

    public int? IntIdArea { get; set; }

    public int? IntIdSubarea { get; set; }

    public DateOnly? FecAlta { get; set; }

    public DateOnly? FecBaja { get; set; }

    public string? IntExt { get; set; }

    public string? NumTelefono1 { get; set; }

    public int? IntIdPromotor { get; set; }

    public bool? BolBloqueado { get; set; }

    public string? NumTelefono2 { get; set; }

    public string? TxtEmail { get; set; }

    public bool? BolPromotor { get; set; }

    public int? IntIdEmpresa { get; set; }

    public string? TxtPassword2 { get; set; }

    public string? TxtPassword3 { get; set; }

    public int? IntIdempleado { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdDepartamentos { get; set; }

    public byte[]? ImgFoto { get; set; }

    public int? IntIdRegion { get; set; }

    public int? IntIdPais { get; set; }

    public bool? BolPassUpdate { get; set; }

    public int? IntIdUnidadNegocio { get; set; }
}
