using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AcademyCSharpLesson21._10._2021
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //SELECT
            using (IDbConnection con = new SqlConnection("Data source=DESKTOP-NP2IPR8\\DEV; Initial catalog=AcademySummer; Integrated security=true"))
            {
                var clients = await con.QueryAsync<Client>("SELECT * FROM CLIENTS");

                foreach (var item in clients)
                {
                    Console.WriteLine(item.LastName + " " + item.FirstName );
                }

            }
            
            //INSERT
            using (IDbConnection con = new SqlConnection("Data source=DESKTOP-NP2IPR8\\DEV; Initial catalog=AcademySummer; Integrated security=true"))
            {
                var clients = await con.ExecuteAsync("INSERT INTO CLIENTS(LastName, FirstName, MiddleName, Created_At) VALUES(@LastName, @FirstName, @MiddleName, @Created_At)",
                    new Client { LastName = "Kirillov", FirstName = "Kirill", MiddleName = " ", Created_At = DateTime.Now });
            }
            
            //UPDATE
            using (IDbConnection con = new SqlConnection("Data source=DESKTOP-NP2IPR8\\DEV; Initial catalog=AcademySummer; Integrated security=true"))
            {
                Client client = new Client { FirstName = "Ali", LastName = "Aliev", Updated_At = DateTime.Now };

                var sqlQuery = $"UPDATE CLIENTS SET FirstName = @FirstName, LastName = @LastName, Updated_At = @Updated_At  WHERE Id = {10} ";
                con.Execute(sqlQuery, client);
            }
            
            using (IDbConnection con = new SqlConnection("Data source=DESKTOP-NP2IPR8\\DEV; Initial catalog=AcademySummer; Integrated security=true"))
            {
                var sqlQuery = "DELETE FROM CLIENTS WHERE Id = @id";
                con.Execute(sqlQuery, new { id = 9 });
            }
        }
    }
}
