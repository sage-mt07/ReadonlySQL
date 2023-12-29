using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string connectionString = configuration.GetConnectionString("SQLServerConnection");
            Console.WriteLine($"SQL Server Connection String: {connectionString}");

            // rity=SSPI;ApplicationIntent=ReadOnly;MultiSubnetFailover=True;


            var str =new SqlConnectionStringBuilder(connectionString);
            str.ApplicationIntent = ApplicationIntent.ReadOnly;
            str.MultiSubnetFailover = true;
            Console.WriteLine($"SQL Server Connection String: {str.ToString()}");

            Console.ReadLine();

        }
    }
}
