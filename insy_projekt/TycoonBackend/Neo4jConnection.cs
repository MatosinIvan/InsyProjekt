using Neo4j.Driver;

namespace TycoonBackend
{
    public class Neo4jConnection
    {
        public IDriver ConDriver { get; private set; }

        public Neo4jConnection()
        {
            var uri = "neo4j://127.0.0.1:7687";
            var user = "neo4j";
            var password = "postgres";
            ConDriver = GraphDatabase.Driver(uri, AuthTokens.Basic(user,password));
        }
        public IDriver GetDriver() { return ConDriver; }
    }
}
