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
    public partial class Uzytkownicy : XPLiteObject
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
        string fKodKreskowy;
        public string KodKreskowy
        {
            get { return fKodKreskowy; }
            set { SetPropertyValue<string>(nameof(KodKreskowy), ref fKodKreskowy, value); }
        }
        bool fNieaktywny;
        public bool Nieaktywny
        {
            get { return fNieaktywny; }
            set { SetPropertyValue<bool>(nameof(Nieaktywny), ref fNieaktywny, value); }
        }
    }

}
