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
namespace Magazyn.Model
{

    [OptimisticLocking(true)]
    public partial class ProduktWykroj : XPLiteObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        Wykroj fWykroj;
        public Wykroj Wykroj
        {
            get { return fWykroj; }
            set { SetPropertyValue<Wykroj>(nameof(Wykroj), ref fWykroj, value); }
        }
        int fIlosc;
        public int Ilosc
        {
            get { return fIlosc; }
            set { SetPropertyValue<int>(nameof(Ilosc), ref fIlosc, value); }
        }
        int fIloscUszkodzone;
        public int IloscUszkodzone
        {
            get { return fIloscUszkodzone; }
            set { SetPropertyValue<int>(nameof(IloscUszkodzone), ref fIloscUszkodzone, value); }
        }
        PZ fPZ;
        [Association(@"ProduktWykrojReferencesPZ")]
        public PZ PZ
        {
            get { return fPZ; }
            set { SetPropertyValue<PZ>(nameof(PZ), ref fPZ, value); }
        }
    }

}
