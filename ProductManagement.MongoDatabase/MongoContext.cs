using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;
using ProductManagement.MongoDatabase.Entities;
using ProductManagement.MongoDatabase.Models;

namespace ProductManagement.MongoDatabase
{
    public class MongoContext
    {
        public IMongoDatabase Database { get; }

        public readonly IMongoCollection<Product> _produtoCollection;

        public MongoContext(IOptions<ProdutoDatabaseSettings> produtoServices)
        {
            var mongoClient = new MongoClient(produtoServices.Value.ConnectionString);
            Database = mongoClient.GetDatabase(produtoServices.Value.DatabaseName);

            _produtoCollection = Database.GetCollection<Product>
                (produtoServices.Value.ProductCollectionName);
        }

        public virtual IMongoCollection<Product> Products => Database.GetCollection<Product>("Products");

    }
}
