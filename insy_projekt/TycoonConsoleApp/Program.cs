using System;
using System.Threading.Tasks;
using Neo4j.Driver;
using TycoonBackend;

namespace MyApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var connection = new Neo4jConnection();
            var driver = connection.GetDriver();
            await using var session = driver.AsyncSession();

            var tmName = "testname";
            var tmRobux = 2000;

            var createQuery = "CREATE (p:Person {name:$name,robux:$robux})";
            var parameters = new {name=tmName,robux=tmRobux};

            await session.RunAsync(createQuery, parameters);
            Console.WriteLine($"{tmName} added successfully");
        }
    }
}