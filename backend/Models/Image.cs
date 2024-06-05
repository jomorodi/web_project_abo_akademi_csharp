
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.models;

public class Image
    {
        [Key]
        public int ImageID { get; set; }

        public string ImageUrl { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }

        public byte[] ImageData { get; set; }
    }
