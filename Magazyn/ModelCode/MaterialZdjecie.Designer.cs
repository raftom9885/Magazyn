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
    public partial class MaterialZdjecie : XPLiteObject
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
        Material fMaterial;
        [Association(@"MaterialZdjecieReferencesMaterial")]
        public Material Material
        {
            get { return fMaterial; }
            set { SetPropertyValue<Material>(nameof(Material), ref fMaterial, value); }
        }
        bool fMiniatura;
        public bool Miniatura
        {
            get { return fMiniatura; }
            set { SetPropertyValue<bool>(nameof(Miniatura), ref fMiniatura, value); }
        }
    }

}
