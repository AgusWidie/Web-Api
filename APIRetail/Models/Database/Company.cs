﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace APIRetail.Models.Database;

public partial class Company
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string Telp { get; set; }

    public string Fax { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<Customer> Customer { get; set; } = new List<Customer>();

    public virtual ICollection<DailyStock> DailyStock { get; set; } = new List<DailyStock>();

    public virtual ICollection<MonthlyStock> MonthlyStock { get; set; } = new List<MonthlyStock>();

    public virtual ICollection<Product> Product { get; set; } = new List<Product>();

    public virtual ICollection<ProductPriceRate> ProductPriceRate { get; set; } = new List<ProductPriceRate>();

    public virtual ICollection<ProductType> ProductType { get; set; } = new List<ProductType>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new List<SalesOrderHeader>();

    public virtual ICollection<SendEmail> SendEmail { get; set; } = new List<SendEmail>();

    public virtual ICollection<SendSms> SendSms { get; set; } = new List<SendSms>();

    public virtual ICollection<SendWhatsapp> SendWhatsapp { get; set; } = new List<SendWhatsapp>();

    public virtual ICollection<StockOpname> StockOpname { get; set; } = new List<StockOpname>();

    public virtual ICollection<Supplier> Supplier { get; set; } = new List<Supplier>();
}