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
    public partial class Wykroj : XPLiteObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        string fNazwa;
        public string Nazwa
        {
            get { return fNazwa; }
            set { SetPropertyValue<string>(nameof(Nazwa), ref fNazwa, value); }
        }
        decimal fSzerokosc;
        public decimal Szerokosc
        {
            get { return fSzerokosc; }
            set { SetPropertyValue<decimal>(nameof(Szerokosc), ref fSzerokosc, value); }
        }
        decimal fWysokosc;
        public decimal Wysokosc
        {
            get { return fWysokosc; }
            set { SetPropertyValue<decimal>(nameof(Wysokosc), ref fWysokosc, value); }
        }
    }

}