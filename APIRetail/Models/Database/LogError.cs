﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace APIRetail.Models.Database;

public partial class LogError
{
    public long Id { get; set; }

    public string ServiceName { get; set; }

    public string ErrorDeskripsi { get; set; }

    public DateTime? ErrorDate { get; set; }

    public string CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }
}