﻿namespace APIRetail.Models.DTO.Response
{
    public class SupplierResponse
    {
        public long Id { get; set; }

        public long? CompanyId { get; set; }

        public string CompanyName { get; set; } = "";

        public long? BranchId { get; set; }

        public string BranchName { get; set; } = "";

        public string Name { get; set; } = "";

        public string Address { get; set; } = "";

        public string Telp { get; set; } = "";

        public string Fax { get; set; } = "";

        public ulong? Active { get; set; }

        public string CreateBy { get; set; } = "";

        public DateTime? CreateDate { get; set; }

        public string UpdateBy { get; set; } = "";

        public DateTime? UpdateDate { get; set; }
    }
}
