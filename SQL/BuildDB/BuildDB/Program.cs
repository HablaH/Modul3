using System;
using System.Data.SqlTypes;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BuildDB
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQuery().Wait();

        }

        static async Task TestQuery()
        {
            var connStr = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TestDB;Integrated Security=True;";
            var conn = new SqlConnection(connStr);

            var queryCreateTable = @"CREATE TABLE [dbo].[Person](
	                                [Id] [int] IDENTITY(1,1) NOT NULL,
	                                [FirstName] [nvarchar](max) NULL,
	                                [LastName] [nvarchar](max) NULL,
	                                [BirthYear] [int] NULL
                                    ) ";

            var insertQuery = @"INSERT INTO Person (FirstName, LastName, BirthYear)
                                VALUES ('Harald', 'Salmelid', '1992')";

            var deleteQuery = @"DECLARE @Id int = 1;
                                DELETE FROM Person WHERE Id = @Id";

            var updateQuery = @"UPDATE Person 
                                SET LastName = 'Jens', FirstName = 'Jensen', BirthYear = '2000'
                                WHERE Id = '1'";

            var affectedRows = await conn.ExecuteAsync(updateQuery);


        }
    }
}
