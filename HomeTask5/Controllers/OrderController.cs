using Dapper;
using HomeTask5.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace HomeTask5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class OrderController: ControllerBase
    {
        private const string connectionString =
                    "Host=localhost;Port=5432;Database=Restaurant_db;Username=postgres;Password=1111";

        [HttpPost]
        public async Task<ActionResult<Orders>> PostOrdersAsync(Orders order)
        {
            using var connection = new NpgsqlConnection(connectionString);
            var insertSql =
                """
                Insert into orders(id,created_at,customer_name,employee_name)
                values(@id,@created_at,@customer_name,@employee_name)
                """;
            await connection.ExecuteAsync(insertSql, order);
            return Ok(order);
        }

        [HttpGet]
        public async Task<ActionResult<List<Orders>>> GetOrdersAsync()
        {
            using var connection = new NpgsqlConnection(connectionString);
            
            var selectSql="Select * from orders";
            var orders = await connection.QueryAsync<Orders>(selectSql);
            return Ok(orders);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Orders>> GetOrderByIdAsync(int id)
        {
            using var connection = new NpgsqlConnection(connectionString);
            var existingOrder = await connection.QueryFirstOrDefaultAsync<Orders>(
                "select * from orders where id = @id", new { id });
            if (existingOrder == null)
            {
                return NotFound();
            }
            var selectSql = "Select * from orders where id = @id";
            var order = await connection.QuerySingleOrDefaultAsync<Orders>(selectSql, new { id });
            return Ok(order);
        }

        [HttpPut]
        public async Task<ActionResult<Orders>> PutOrdersAsync(Orders order)
        {
            using var connection = new NpgsqlConnection(connectionString);
            var existingOrder = await connection.QueryFirstOrDefaultAsync<Orders>(
                "select * from orders where id = @id", new { order.Id });
            if (existingOrder is  null)
            {
                return NotFound();
            }
            var updateSql =
                """
                update orders
                set created_at = @created_at, customer_name = @customer_name,employee_name = @employee_name
                where id=@id
                """;
            await connection.ExecuteAsync(updateSql, order);
            return Ok(order);
        }
        
        [HttpDelete]
        public async Task<ActionResult<Orders>>DeleteOrdersAsync(int id)
        {
            using var connection = new NpgsqlConnection(connectionString);
            var existingOrder = await connection.QueryFirstOrDefaultAsync<Orders>(
                "select * from orders where id = @id", new { id });
            if (existingOrder == null)
            {
                return NotFound();
            }

            var deleteSql = "delete from orders where id = @id";
            await connection.ExecuteAsync(deleteSql, new { id });
            return Ok("Order deleted saccessfully");
        } 
    }
}
