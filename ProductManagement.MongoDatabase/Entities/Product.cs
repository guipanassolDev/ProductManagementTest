using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ProductManagement.MongoDatabase;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.MongoDatabase.Entities
{
    public class Product : Entity
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
