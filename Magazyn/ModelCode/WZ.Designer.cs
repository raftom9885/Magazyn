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
    public partial class WZ : XPLiteObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        Uzytkownicy fUzytkownik;
        public Uzytkownicy Uzytkownik
        {
            get { return fUzytkownik; }
            set { SetPropertyValue<Uzytkownicy>(nameof(Uzytkownik), ref fUzytkownik, value); }
        }
        Bela fBela;
        [Association(@"WZReferencesBela")]
        public Bela Bela
        {
            get { return fBela; }
            set { SetPropertyValue<Bela>(nameof(Bela), ref fBela, value); }
        }
        decimal fIlosc;
        public decimal Ilosc
        {
            get { return fIlosc; }
            set { SetPropertyValue<decimal>(nameof(Ilosc), ref fIlosc, value); }
        }
        DateTime fData;
        public DateTime Data
        {
            get { return fData; }
            set { SetPropertyValue<DateTime>(nameof(Data), ref fData, value); }
        }
        bool fRozliczono;
        public bool Rozliczono
        {
            get { return fRozliczono; }
            set { SetPropertyValue<bool>(nameof(Rozliczono), ref fRozliczono, value); }
        }
    }

}
