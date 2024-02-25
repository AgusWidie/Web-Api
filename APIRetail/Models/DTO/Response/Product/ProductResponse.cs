﻿namespace APIRetail.Models.DTO.Response
{
    public class ProductResponse
    {
        public long Id { get; set; }

        public long? CompanyId { get; set; }

        public string CompanyName { get; set; }

        public long? BranchId { get; set; }

        public string BranchName { get; set; }

        public long? ProductTypeId { get; set; }

        public string ProductTypeName { get; set; }

        public string ProductName { get; set; }

        public string ProductNo { get; set; }

        public long? BuyPrice { get; set; }

        public long? SellPrice { get; set; }

        public string Description { get; set; } = "";

        public ulong? Active { get; set; }

        public string CreateBy { get; set; } = "";

        public DateTime? CreateDate { get; set; }

        public string UpdateBy { get; set; } = "";

        public DateTime? UpdateDate { get; set; }
    }
}
