using System.ComponentModel.DataAnnotations.Schema;

namespace AkanekoDBManager.Entities;

[Table("DishIngredient")]
public class DishIngredient
{
    public int DishId { get; set; }
    public int IngredientId { get; set; }
    
    public float Amount { get; set; }
}