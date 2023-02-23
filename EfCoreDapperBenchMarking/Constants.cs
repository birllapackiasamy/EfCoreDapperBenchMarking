using System.Data.SqlClient;

namespace DapperEFCorePerformanceBenchmarks
{
    public static class Constants
    {
        private static readonly SqlConnectionStringBuilder sConnB = new SqlConnectionStringBuilder()
        {
            DataSource = "YOURSERVERNAME",
            InitialCatalog = "YOUR SCHEMA NAME",
            UserID = "USERNAME",
            Password = "PASSWORD",
            TrustServerCertificate = true
        };

        public static readonly string SportsConnectionString = sConnB.ConnectionString;
    }
}