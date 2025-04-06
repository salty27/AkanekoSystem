using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkanekoDBManager.Entities;

[Table("DeliveryInfo")]
public class DeliveryInfo
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Timestamp]
    public byte[] Date { get; set; }
    
    [Required, StringLength(50)]
    public string Company { get; set; }
    
    public List<DeliveryData> DeliveryData { get; set; }
}