using System.ComponentModel.DataAnnotations.Schema;

namespace AkanekoDBManager.Entities;

[Table("DishOrder")]
public class DishOrder
{
    public int DishId { get; set; }
    public int OrderId { get; set; }
    
    public int Amount { get; set; }
}