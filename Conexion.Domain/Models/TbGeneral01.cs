using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbGeneral01
{
    public Guid LngIdGeneral { get; set; }

    public Guid? LngIdCliente { get; set; }

    public Guid? IntIdTipoCliente { get; set; }

    public Guid? IntIdPromotor { get; set; }

    public Guid? IntIdOficina { get; set; }

    public Guid? IntIdSucursal { get; set; }

    public Guid? IntIdTipoContrato { get; set; }

    public Guid? IntIdTipoCuenta { get; set; }

    public Guid? IntIdDiscrecionalidad { get; set; }

    public bool? BolImpuesto { get; set; }

    public Guid? IntIdTipoInstrumento { get; set; }

    public string? TxtRazonSocial { get; set; }

    public string? TxtRfc { get; set; }

    public string? TxtNoSerieFirma { get; set; }

    public Guid? IntIdGiro { get; set; }

    public Guid? IntIdActividad { get; set; }

    public Guid? IntIdNacionalidad { get; set; }

    public Guid? IntIdPais { get; set; }

    public Guid? IntIdEntidadFederativa { get; set; }

    public Guid? IntIdDelMun { get; set; }

    public string? TxtDireccion { get; set; }

    public string? TxtNoExterior { get; set; }

    public string? TxtNoInterior { get; set; }

    public string? TxtColonia { get; set; }

    public string? TxtCodigoPostal { get; set; }

    public string? TxtTelOficina { get; set; }

    public string? TxtExtension { get; set; }

    public string? TxtEmail { get; set; }

    public bool? BolCongelar { get; set; }
}
