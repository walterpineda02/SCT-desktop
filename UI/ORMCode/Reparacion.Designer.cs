﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace UI.sct
{

    public partial class Reparacion : XPLiteObject
    {
        int fIdReparacion;
        [Key(true)]
        public int IdReparacion
        {
            get { return fIdReparacion; }
            set { SetPropertyValue<int>(nameof(IdReparacion), ref fIdReparacion, value); }
        }
        Usuario fIdUsuarioCliente;
        [Association(@"ReparacionReferencesUsuario")]
        public Usuario IdUsuarioCliente
        {
            get { return fIdUsuarioCliente; }
            set { SetPropertyValue<Usuario>(nameof(IdUsuarioCliente), ref fIdUsuarioCliente, value); }
        }
        Usuario fIdUsuarioTrabajador;
        [Association(@"ReparacionReferencesUsuario1")]
        public Usuario IdUsuarioTrabajador
        {
            get { return fIdUsuarioTrabajador; }
            set { SetPropertyValue<Usuario>(nameof(IdUsuarioTrabajador), ref fIdUsuarioTrabajador, value); }
        }
        DateTime fFechaIngreso;
        public DateTime FechaIngreso
        {
            get { return fFechaIngreso; }
            set { SetPropertyValue<DateTime>(nameof(FechaIngreso), ref fFechaIngreso, value); }
        }
        DateTime fFechaSalida;
        public DateTime FechaSalida
        {
            get { return fFechaSalida; }
            set { SetPropertyValue<DateTime>(nameof(FechaSalida), ref fFechaSalida, value); }
        }
        string fEstado;
        public string Estado
        {
            get { return fEstado; }
            set { SetPropertyValue<string>(nameof(Estado), ref fEstado, value); }
        }
        bool fIdEstadoRegistro;
        public bool IdEstadoRegistro
        {
            get { return fIdEstadoRegistro; }
            set { SetPropertyValue<bool>(nameof(IdEstadoRegistro), ref fIdEstadoRegistro, value); }
        }
        DateTime fFechaCreacion;
        public DateTime FechaCreacion
        {
            get { return fFechaCreacion; }
            set { SetPropertyValue<DateTime>(nameof(FechaCreacion), ref fFechaCreacion, value); }
        }
        int fIdUsuarioCreacion;
        public int IdUsuarioCreacion
        {
            get { return fIdUsuarioCreacion; }
            set { SetPropertyValue<int>(nameof(IdUsuarioCreacion), ref fIdUsuarioCreacion, value); }
        }
        string fDireccionEquipoCreacion;
        [Size(25)]
        public string DireccionEquipoCreacion
        {
            get { return fDireccionEquipoCreacion; }
            set { SetPropertyValue<string>(nameof(DireccionEquipoCreacion), ref fDireccionEquipoCreacion, value); }
        }
        DateTime fFechaModificacion;
        public DateTime FechaModificacion
        {
            get { return fFechaModificacion; }
            set { SetPropertyValue<DateTime>(nameof(FechaModificacion), ref fFechaModificacion, value); }
        }
        int fIdUsuarioModificacion;
        public int IdUsuarioModificacion
        {
            get { return fIdUsuarioModificacion; }
            set { SetPropertyValue<int>(nameof(IdUsuarioModificacion), ref fIdUsuarioModificacion, value); }
        }
        string fDireccionEquipoModificacion;
        [Size(25)]
        public string DireccionEquipoModificacion
        {
            get { return fDireccionEquipoModificacion; }
            set { SetPropertyValue<string>(nameof(DireccionEquipoModificacion), ref fDireccionEquipoModificacion, value); }
        }
        [Association(@"DetalleReparacionReferencesReparacion")]
        public XPCollection<DetalleReparacion> DetalleReparacions { get { return GetCollection<DetalleReparacion>(nameof(DetalleReparacions)); } }
    }

}