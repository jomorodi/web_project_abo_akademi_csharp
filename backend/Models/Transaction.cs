using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.models
{
    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed
    }

    public enum OrderStatus
    {
        Pending,
        Delivered,
        Shipped,
        Canceled
    }

    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        
        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        
        
        public DateTime TransactionDate { get; set; }

        public virtual Item Item { get; set; }
        
        public virtual User Buyer { get; set; }
        
        
        public PaymentStatus PaymentStatus { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public decimal Amount { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
        
       
    }
}