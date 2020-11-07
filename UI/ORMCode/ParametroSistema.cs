using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace UI.sct
{

    public partial class ParametroSistema
    {
        public ParametroSistema(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
