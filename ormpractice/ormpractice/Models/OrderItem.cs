namespace ormpractice.Models;

public class OrderItem
{
    public int Id { get; set; }
    
    public string ProductName { get; set; }= null!;
    
    public decimal Price { get; set; }
    
    public int OrderId { get; set; }
    
    public Order Order { get; set; }= null!;
}