using Dapper;
using HomeTask5.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace HomeTask5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddController : ControllerBase
    {
        private const string connectionString =
            "Host=localhost;Port=5432;Database=Restaurant_db;Username=postgres;Password=1111";

        [HttpGet]
        public async Task<ActionResult<List<Orders>>> GetAllOrderWithOrderDetailsById(int id)
        {
            using var connection=new NpgsqlConnection(connectionString);
            var selectSql =
                """
                Select * from Orders where id=(Select order_id from OrderDetails where id=@id)
                """;
            var order = await connection.QueryFirstAsync<Orders>(selectSql, new { id});
            return Ok(order);
        }
    }
}

