﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Magazyn.Model
{

    public partial class PZ
    {
        public PZ(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
