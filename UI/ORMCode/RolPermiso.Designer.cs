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

    public partial class RolPermiso : XPLiteObject
    {
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
        public struct CompoundKey1Struct
        {
            [Persistent("IdRol")]
            public byte IdRol { get; set; }
            [Persistent("IdPermiso")]
            public string IdPermiso { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}
