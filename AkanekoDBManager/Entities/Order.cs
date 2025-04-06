using System.ComponentModel.DataAnnotations.Schema;

namespace AkanekoDBManager.Entities;

[Table("Order")]
public class Order
{
    public int Id { get; set; }
    public int Table  { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public float Price { get; set; }
    
    public List<Dish> Dishes { get; set; }
}