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

    public partial class Menu : XPLiteObject
    {
        int fIdMenu;
        [Key]
        public int IdMenu
        {
            get { return fIdMenu; }
            set { SetPropertyValue<int>(nameof(IdMenu), ref fIdMenu, value); }
        }
        int fIdMenuPadre;
        public int IdMenuPadre
        {
            get { return fIdMenuPadre; }
            set { SetPropertyValue<int>(nameof(IdMenuPadre), ref fIdMenuPadre, value); }
        }
        string fNombre;
        [Size(150)]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fIdPermiso;
        public string IdPermiso
        {
            get { return fIdPermiso; }
            set { SetPropertyValue<string>(nameof(IdPermiso), ref fIdPermiso, value); }
        }
        string fIcono;
        [Size(150)]
        public string Icono
        {
            get { return fIcono; }
            set { SetPropertyValue<string>(nameof(Icono), ref fIcono, value); }
        }
        string fDireccionWeb;
        [Size(150)]
        public string DireccionWeb
        {
            get { return fDireccionWeb; }
            set { SetPropertyValue<string>(nameof(DireccionWeb), ref fDireccionWeb, value); }
        }
        int fOrden;
        public int Orden
        {
            get { return fOrden; }
            set { SetPropertyValue<int>(nameof(Orden), ref fOrden, value); }
        }
    }

}
