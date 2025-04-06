using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AkanekoDBManager.Entities;


[Table("DeliveryData")]
[PrimaryKey(nameof(DeliveryInfoId), nameof(IngredientId))]
public class DeliveryData
{
    [ForeignKey(nameof(DeliveryInfo))]
    public int DeliveryInfoId { get; set; }
    [ForeignKey(nameof(Ingredient))]
    public int IngredientId { get; set; }
    public DeliveryInfo DeliveryInfo { get; set; }
    public Ingredient Ingredient { get; set; }
    
    public int Quantity { get; set; }
}