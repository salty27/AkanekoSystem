using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkanekoDBManager.Entities;

[Table("Ingredients")]
public class Ingredient
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required, StringLength(50)]
    public string Name { get; set; }
    [Required]
    public int ActualQuantity { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int ExpectedQuantity { get; set; }

    public List<Dish> Dishes { get; set; } = [];
    public List<DishIngredient> DishIngredients { get; set; } = [];
}