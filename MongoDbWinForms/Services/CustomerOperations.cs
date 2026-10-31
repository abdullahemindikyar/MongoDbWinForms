using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbWinForms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbWinForms.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            // Create a connection to the MongoDB database and get the customer collection
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();

            // Create a BsonDocument from the Customer object
            var document = new BsonDocument
            {
                { "CustomerName", customer.CustomerName },
                { "CustomerSurname", customer.CustomerSurname },
                { "CustomerCity", customer.CustomerCity },
                { "CustomerBalance", customer.CustomerBalance },
                { "CustomerShoppingCount", customer.CustomerShoppingCount}
            };

            // Insert the document into the collection 
            customerCollection.InsertOne(document);
        }

        public List<Customer> GetAllCustomer()
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var customers = customerCollection.Find(new BsonDocument()).ToList();

            List<Customer> customerList = new List<Customer>();

            foreach (var c in customers)
            {
               customerList.Add(new Customer
               {
                   CustomerId = c["_id"].ToString(),
                   CustomerName = c["CustomerName"].AsString,
                   CustomerSurname = c["CustomerSurname"].AsString,
                   CustomerCity = c["CustomerCity"].AsString,
                   CustomerBalance = c["CustomerBalance"].AsDecimal,
                   CustomerShoppingCount = c["CustomerShoppingCount"].AsInt32
               });
            }

            return customerList;
        }

        public void DeleteCustomer(string customerId)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));
            customerCollection.DeleteOne(filter); 
        }

        public void UpdateCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            var update = Builders<BsonDocument>.Update
                .Set("CustomerName", customer.CustomerName)
                .Set("CustomerSurname", customer.CustomerSurname)
                .Set("CustomerCity", customer.CustomerCity)
                .Set("CustomerBalance", customer.CustomerBalance)
                .Set("CustomerShoppingCount", customer.CustomerShoppingCount);
            customerCollection.UpdateOne(filter, update);
        }

        public Customer GetCustomerById(string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var customerDocument = customerCollection.Find(filter).FirstOrDefault();
            return new Customer
            {
                CustomerId = customerDocument["_id"].ToString(),
                CustomerName = customerDocument["CustomerName"].AsString,
                CustomerSurname = customerDocument["CustomerSurname"].AsString,
                CustomerCity = customerDocument["CustomerCity"].AsString,
                CustomerBalance = customerDocument["CustomerBalance"].AsDecimal,
                CustomerShoppingCount = customerDocument["CustomerShoppingCount"].AsInt32
            };

        }
    }
}
