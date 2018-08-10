using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace Tables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

            var tableClient = storageAccount.CreateCloudTableClient();

            var table = tableClient.GetTableReference("customers");

            table.CreateIfNotExists();
            Console.WriteLine("Customer table created!");

            CreateCustomer(table, new CustomerUS("Anders", "anders@localhost.local"));
            CreateCustomer(table, new CustomerUS("Bo", "bo@localhost.local"));
            CreateCustomer(table, new CustomerUS("Rasmussen", "rasmussen@localhost.local"));
            GetCustomer(table, "US", "anders@localhost.local");
            GetAllCustomers(table);

            var customer = GetCustomer(table, "US", "bo@localhost.local");

            customer.Name = "Autzen";
            UpdateCustomer(table, customer);
            GetAllCustomers(table);

            DeleteCustomer(table, customer);
            GetAllCustomers(table);

            CreateCustomersBatch(table);
            GetAllCustomers(table);

            Console.ReadKey();
        }

        public static void CreateCustomer(CloudTable table, CustomerUS customer)
        {
            var insert = TableOperation.Insert(customer);

            table.Execute(insert);
        }

        public static CustomerUS GetCustomer(CloudTable table, string partitionkey, string rowKey)
        {
            var retrieve = TableOperation.Retrieve<CustomerUS>(partitionkey, rowKey);

            var result = table.Execute(retrieve);

            return (CustomerUS)result.Result;
        }

        public static void GetAllCustomers(CloudTable table)
        {
            var query = new TableQuery<CustomerUS>()
                .Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "US"));

            foreach(var customer in table.ExecuteQuery(query))
            {
                Console.WriteLine(customer.Name);
            }
        }

        public static void UpdateCustomer(CloudTable table, CustomerUS customer)
        {
            var update = TableOperation.Replace(customer);

            table.Execute(update);
        }

        public static void DeleteCustomer(CloudTable table, CustomerUS customer)
        {
            var delete = TableOperation.Delete(customer);

            table.Execute(delete);
        }

        public static void CreateCustomersBatch(CloudTable table)
        {
            var batch = new TableBatchOperation();

            batch.Insert(new CustomerUS("Frank", "frank@localhost.local"));
            batch.Insert(new CustomerUS("Steve", "steve@localhost.local"));
            batch.Insert(new CustomerUS("Joe", "joe@localhost.local"));

            table.ExecuteBatch(batch);
        }
    }

    public class CustomerUS : TableEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public CustomerUS(string name, string email)
        {
            Name = name;
            Email = email;
            PartitionKey = "US";
            RowKey = email;
        }

        public CustomerUS() { }
    }
}
