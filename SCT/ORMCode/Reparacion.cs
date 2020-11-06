using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SCT.sct
{

    public partial class Reparacion
    {
        public Reparacion(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
