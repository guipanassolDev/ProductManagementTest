using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.MongoDatabase.Models
{
    public class ProdutoDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; } 
        public string ProductCollectionName { get; set; } 
    }
}
