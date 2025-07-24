namespace HomeTask5.Models;

public class OrderDetails
{
    public int Id { get; set; }
    public int Order_Id { get; set; }
    public string Product_name { get; set; }
    public decimal Unit_price { get; set; }
    public int Quantity { get; set; }
}