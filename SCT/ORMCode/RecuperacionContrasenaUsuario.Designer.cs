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
namespace SCT.sct
{

    public partial class RecuperacionContrasenaUsuario : XPLiteObject
    {
        string fIdRecuperacionContrasenaUsuario;
        [Key]
        [Size(50)]
        public string IdRecuperacionContrasenaUsuario
        {
            get { return fIdRecuperacionContrasenaUsuario; }
            set { SetPropertyValue<string>(nameof(IdRecuperacionContrasenaUsuario), ref fIdRecuperacionContrasenaUsuario, value); }
        }
        int fIdUsuario;
        public int IdUsuario
        {
            get { return fIdUsuario; }
            set { SetPropertyValue<int>(nameof(IdUsuario), ref fIdUsuario, value); }
        }
        DateTime fFechaEmision;
        public DateTime FechaEmision
        {
            get { return fFechaEmision; }
            set { SetPropertyValue<DateTime>(nameof(FechaEmision), ref fFechaEmision, value); }
        }
        DateTime fFechaExpiracion;
        public DateTime FechaExpiracion
        {
            get { return fFechaExpiracion; }
            set { SetPropertyValue<DateTime>(nameof(FechaExpiracion), ref fFechaExpiracion, value); }
        }
        bool fAutorizado;
        [ColumnDbDefaultValue("((0))")]
        public bool Autorizado
        {
            get { return fAutorizado; }
            set { SetPropertyValue<bool>(nameof(Autorizado), ref fAutorizado, value); }
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
        [Size(20)]
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
        [Size(20)]
        public string DireccionEquipoModificacion
        {
            get { return fDireccionEquipoModificacion; }
            set { SetPropertyValue<string>(nameof(DireccionEquipoModificacion), ref fDireccionEquipoModificacion, value); }
        }
    }

}
