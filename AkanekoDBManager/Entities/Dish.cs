using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkanekoDBManager.Entities;

[Table("Dish")]
public class Dish
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public float Price { get; set; }
    
    public List<Ingredient> Ingredients { get; set; } = [];
    public List<DishIngredient> DishIngredients { get; set; } = [];
}