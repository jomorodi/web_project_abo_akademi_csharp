using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shop ;

public class Transaction
{
    [Key]
    public int TransactionId { get; set; }
    
    [ForeignKey("Item")]
    public int ItemId { get; set; }
    
    [ForeignKey("User")]
    public int BuyerId { get; set; }
    
    [ForeignKey("User")]
    public int SellerId { get; set; }
    
    public DateTime TransactionDate { get; set; }
    
    public virtual Item Item { get; set; }
    
    public virtual User Buyer { get; set; }
    
    public virtual User Seller { get; set; }
}
