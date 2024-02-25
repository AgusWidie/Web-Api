﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace APIRetail.Models.Database;

public partial class Customer
{
    public long Id { get; set; }

    public long? CompanyId { get; set; }

    public long? BranchId { get; set; }

    public string Ktpnumber { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string Telephone { get; set; }

    public string WhatsApp { get; set; }

    public string Email { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Branch Branch { get; set; }

    public virtual Company Company { get; set; }

    public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new List<SalesOrderHeader>();

    public virtual ICollection<SendEmail> SendEmail { get; set; } = new List<SendEmail>();

    public virtual ICollection<SendSms> SendSms { get; set; } = new List<SendSms>();

    public virtual ICollection<SendWhatsapp> SendWhatsapp { get; set; } = new List<SendWhatsapp>();
}