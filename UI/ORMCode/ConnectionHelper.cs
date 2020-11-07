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
    public static class ConnectionHelper
    {
        static Type[] persistentTypes = new Type[] {
            typeof(Archivo),
            typeof(Auditoria),
            typeof(AuditoriaDetalle),
            typeof(Categoria),
            typeof(DetalleReparacion),
            typeof(Equipo),
            typeof(HistorialDireccionEquipo),
            typeof(Menu),
            typeof(Modulo),
            typeof(ParametroSistema),
            typeof(Permiso),
            typeof(RecuperacionContrasenaUsuario),
            typeof(Reparacion),
            typeof(Rol),
            typeof(RolPermiso),
            typeof(Usuario)
        };
        public static Type[] GetPersistentTypes()
        {
            Type[] copy = new Type[persistentTypes.Length];
            Array.Copy(persistentTypes, copy, persistentTypes.Length);
            return copy;
        }
        public const string ConnectionString = @"XpoProvider=MSSqlServer;data source=DIACACHIMBA;integrated security=SSPI;initial catalog=sct";
        public static void Connect(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, bool threadSafe = false)
        {
            if (threadSafe)
            {
                var provider = XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
                var dictionary = new DevExpress.Xpo.Metadata.ReflectionDictionary();
                dictionary.GetDataStoreSchema(persistentTypes);
                XpoDefault.DataLayer = new ThreadSafeDataLayer(dictionary, provider);
            }
            else
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
            }
            XpoDefault.Session = null;
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption, out objectsToDisposeOnDisconnect);
        }
        public static IDataLayer GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
        }
    }

}