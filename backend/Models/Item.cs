using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shop ;
public class Item
{
    [Key]
    public int ItemId { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    
    [ForeignKey("User")]
    public int SellerId { get; set; }
    
    public bool IsSold { get; set; }
    
    public virtual User Seller { get; set; }
}

