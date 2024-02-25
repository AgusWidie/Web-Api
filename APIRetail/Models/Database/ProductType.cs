﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace APIRetail.Models.Database;

public partial class ProductType
{
    public long Id { get; set; }

    public long? CompanyId { get; set; }

    public long? BranchId { get; set; }

    public string ProductTypeName { get; set; }

    public string Description { get; set; }

    public ulong? Active { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Branch Branch { get; set; }

    public virtual Company Company { get; set; }

    public virtual ICollection<DailyStock> DailyStock { get; set; } = new List<DailyStock>();

    public virtual ICollection<MonthlyStock> MonthlyStock { get; set; } = new List<MonthlyStock>();

    public virtual ICollection<Product> Product { get; set; } = new List<Product>();

    public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; } = new List<PurchaseOrderDetail>();

    public virtual ICollection<SalesOrderDetail> SalesOrderDetail { get; set; } = new List<SalesOrderDetail>();

    public virtual ICollection<StockOpname> StockOpname { get; set; } = new List<StockOpname>();
}