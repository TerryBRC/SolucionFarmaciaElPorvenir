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
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace FarmaciaElPorvenir.el_porvenirdb
{

    [Persistent(@"medicamento")]
    public partial class Medicamento : XPLiteObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        string fNombre;
        [Size(50)]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        float fPrecio;
        public float Precio
        {
            get { return fPrecio; }
            set { SetPropertyValue<float>(nameof(Precio), ref fPrecio, value); }
        }
        Categoria fId_Categoria;
        [Association(@"MedicamentoReferencesCategoria")]
        public Categoria Id_Categoria
        {
            get { return fId_Categoria; }
            set { SetPropertyValue<Categoria>(nameof(Id_Categoria), ref fId_Categoria, value); }
        }
        Laboratorio fId_Laboratorio;
        [Association(@"MedicamentoReferencesLaboratorio")]
        public Laboratorio Id_Laboratorio
        {
            get { return fId_Laboratorio; }
            set { SetPropertyValue<Laboratorio>(nameof(Id_Laboratorio), ref fId_Laboratorio, value); }
        }
        [Association(@"Factura_compraReferencesMedicamento")]
        public XPCollection<Factura_compra> Factura_compras { get { return GetCollection<Factura_compra>(nameof(Factura_compras)); } }
        [Association(@"InventarioReferencesMedicamento")]
        public XPCollection<Inventario> Inventarios { get { return GetCollection<Inventario>(nameof(Inventarios)); } }
    }

}
