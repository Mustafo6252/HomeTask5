
using Dapper;
using HomeTask5.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace HomeTask5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class OrderDetailsController: ControllerBase
    {
        private const string connectionString =
            "Host=localhost;Port=5432;Database=Restaurant_db;Username=postgres;Password=1111";

        [HttpPost]
        public async Task<ActionResult<OrderDetails>> PostOrderDetailsAsync(OrderDetails orderDetails)
        {
            using var connection = new NpgsqlConnection(connectionString);
            var insertSql =
                """
                    Insert into OrderDetails(id,order_id,product_name,unit_price,quantity)
                    Values(@id,@order_id,@product_name,@unit_price,@quantity);
                """;
            await connection.ExecuteAsync(insertSql, orderDetails);
            return Ok(orderDetails);
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDetails>>> GetOrderDetailsAsync()
        {
            using var connection = new NpgsqlConnection(connectionString);
            var selectSql ="Select * from OrderDetails";
            var orderDetails = await connection.QueryAsync<OrderDetails>(selectSql);
            return Ok(orderDetails);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetails>> GetOrderDetailsByIdAsync(int id)
        {
            using var connection = new NpgsqlConnection(connectionString);
            var existingOrderDetails = await connection.QueryFirstOrDefaultAsync<OrderDetails>(
                "select * from OrderDetails where id = @id", new { id });
            if (existingOrderDetails == null)
            {
                return NotFound();
            }

            var selectSql="Select * from OrderDetails Where id = @id";
            var orderDetails = await connection.QueryAsync<OrderDetails>(selectSql, new { id });
            return Ok(existingOrderDetails);
        }

        [HttpPut]
        public async Task<ActionResult<OrderDetails>> PutOrderDetailsAsync(OrderDetails orderDetails)
        {
            using var connection = new NpgsqlConnection(connectionString);
            var existingOrderDetails = await connection.QueryFirstOrDefaultAsync<OrderDetails>(
                "select * from OrderDetails where id = @id", new { orderDetails.Id });
            if (existingOrderDetails == null)
            {
                return NotFound();
            }

            var updateSql =
                """
                    update OrderDetails 
                    set order_id = @order_id,product_name = @product_name,unit_price = @unit_price,quantity = @quantity
                    where id = @id
                """;
            await connection.ExecuteAsync(updateSql, orderDetails);
            return Ok(orderDetails);
        }

        [HttpDelete]
        public async Task<ActionResult<OrderDetails>> DeleteOrderDetailsAsync(int id)
        {
            using var connection = new NpgsqlConnection(connectionString);
            var existingOrderDetails = await connection.QueryFirstOrDefaultAsync<OrderDetails>(
                "select * from OrderDetails where id = @id", new { id });
            if (existingOrderDetails == null)
            {
                return NotFound();
            }
            var deleteSql = "delete from OrderDetails where id = @id";
            await connection.ExecuteAsync(deleteSql, new { id });
            return Ok(existingOrderDetails);
        }
    }
}
