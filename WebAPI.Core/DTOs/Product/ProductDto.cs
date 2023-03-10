using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.DTOs.Product
{
    public class ProductDto
    {
        public int Code { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime? FabricationDate { get; set; }

        public DateTime? ValidationDate { get; set; }

        public int? SupplierCode { get; set; }

        public string? SupplierDescription { get; set; }

        public string? SupplierCnpj { get; set; }
    }
}
