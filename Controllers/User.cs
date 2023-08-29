using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Nodes;
using Npgsql;
using static WaqafCloudLibrary.Database;

namespace RaisWaqafCloud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class User : ControllerBase
    {
        [HttpGet]
        [Route("User")]
        public JsonNode? UserInfo() {
            string connectionString = "Host=localhost;Port=5432;Database=ruser;Username=postgres;Password=x;";
            string sql = "SELECT * FROM user_accounts";
            return ExecuteSqlQuery(sql, connectionString);
        }
    }
}